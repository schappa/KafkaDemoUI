using System.Diagnostics.CodeAnalysis;

namespace KafkaDemoUI
{
    public partial class Form1 : Form
    {

        private KafkaEngine _kafkaEngine;
        public Form1()
        {
            InitializeComponent();
            InitKafka();
            
        }

        private void InitKafka()
        {

            try
            {
                _kafkaEngine = new KafkaEngine("getting_started.properties");
                this.cboTopics.Items.AddRange(_kafkaEngine.Topics.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSubmitMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    MessageBox.Show("No message to process", "Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string topicName = this.cboTopics.Text;
                var error = _kafkaEngine.ValidateTopic(topicName);

                if (error.Code == Confluent.Kafka.ErrorCode.NoError)
                {
                    var frmConsumer = new FormConsumer() { TopicName = topicName };
                    frmConsumer.Show();
                }
                else if (error.Code == Confluent.Kafka.ErrorCode.UnknownTopicOrPart)
                {
                    if (!cbxCreateTopic.Checked)
                    {
                        MessageBox.Show("Topic does not exist!  If you wish to creat this topic, check the checkbox and resubmit.", "Invalid Topic", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        _kafkaEngine.CreateTopic(topicName);
                        var frmConsumer = new FormConsumer() { TopicName = topicName };
                        frmConsumer.ShowDialog();

                        _kafkaEngine.ProduceMessage(this.txtMessage.Text, topicName);
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}