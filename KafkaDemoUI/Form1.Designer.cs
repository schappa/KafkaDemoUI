namespace KafkaDemoUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTopic = new System.Windows.Forms.Label();
            this.cboTopics = new System.Windows.Forms.ComboBox();
            this.lbConsumer = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblConsumer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSubmitMessage = new System.Windows.Forms.Button();
            this.cbxCreateTopic = new System.Windows.Forms.CheckBox();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(12, 30);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(35, 15);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = "Topic";
            // 
            // cboTopics
            // 
            this.cboTopics.FormattingEnabled = true;
            this.cboTopics.Location = new System.Drawing.Point(12, 48);
            this.cboTopics.Name = "cboTopics";
            this.cboTopics.Size = new System.Drawing.Size(121, 23);
            this.cboTopics.TabIndex = 3;
            this.cboTopics.SelectedIndexChanged += new System.EventHandler(this.cboTopics_SelectedIndexChanged);
            // 
            // lbConsumer
            // 
            this.lbConsumer.FormattingEnabled = true;
            this.lbConsumer.ItemHeight = 15;
            this.lbConsumer.Location = new System.Drawing.Point(267, 130);
            this.lbConsumer.Name = "lbConsumer";
            this.lbConsumer.Size = new System.Drawing.Size(179, 214);
            this.lbConsumer.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 130);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(208, 214);
            this.txtMessage.TabIndex = 5;
            // 
            // lblConsumer
            // 
            this.lblConsumer.AutoSize = true;
            this.lblConsumer.Location = new System.Drawing.Point(267, 112);
            this.lblConsumer.Name = "lblConsumer";
            this.lblConsumer.Size = new System.Drawing.Size(62, 15);
            this.lblConsumer.TabIndex = 6;
            this.lblConsumer.Text = "Consumer";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 112);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message";
            // 
            // btnSubmitMessage
            // 
            this.btnSubmitMessage.Location = new System.Drawing.Point(145, 350);
            this.btnSubmitMessage.Name = "btnSubmitMessage";
            this.btnSubmitMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitMessage.TabIndex = 8;
            this.btnSubmitMessage.Text = "Submit";
            this.btnSubmitMessage.UseVisualStyleBackColor = true;
            this.btnSubmitMessage.Click += new System.EventHandler(this.btnSubmitMessage_Click);
            // 
            // cbxCreateTopic
            // 
            this.cbxCreateTopic.AutoSize = true;
            this.cbxCreateTopic.Location = new System.Drawing.Point(145, 50);
            this.cbxCreateTopic.Name = "cbxCreateTopic";
            this.cbxCreateTopic.Size = new System.Drawing.Size(174, 19);
            this.cbxCreateTopic.TabIndex = 9;
            this.cbxCreateTopic.Text = "Create if topic doesn\'t exist?";
            this.cbxCreateTopic.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.Location = new System.Drawing.Point(48, 77);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteTopic.TabIndex = 10;
            this.btnDeleteTopic.Text = "DeleteTopic";
            this.btnDeleteTopic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 380);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.cbxCreateTopic);
            this.Controls.Add(this.btnSubmitMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblConsumer);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lbConsumer);
            this.Controls.Add(this.cboTopics);
            this.Controls.Add(this.lblTopic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTopic;
        private ComboBox cboTopics;
        private ListBox lbConsumer;
        private TextBox txtMessage;
        private Label lblConsumer;
        private Label lblMessage;
        private Button btnSubmitMessage;
        private CheckBox cbxCreateTopic;
        private Button btnDeleteTopic;
    }
}