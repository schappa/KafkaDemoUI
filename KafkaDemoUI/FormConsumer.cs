using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaDemoUI
{
    public partial class FormConsumer : Form
    {
        private KafkaConsumer _kafkaConsumer;

        public string TopicName { get; set; }


        public FormConsumer()
        {
            InitializeComponent();
        }

        private void FormConsumer_Load(object sender, EventArgs e)
        {

        }
    }
}
