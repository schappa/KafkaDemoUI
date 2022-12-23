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

                throw;
            }
            
        }

        private void btnSubmitMessage_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("No message to process", "Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
                return; 
            }
        }

        private void cboTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool doesTopicExist = _kafkaEngine.ValidateTopic(this.cboTopics.SelectedItem.ToString());
        }
    }
}