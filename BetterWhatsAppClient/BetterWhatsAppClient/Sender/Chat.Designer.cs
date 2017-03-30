namespace BetterWhatsAppClient.Sender
{
    partial class Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userSelectComboBox = new System.Windows.Forms.ComboBox();
            this.chatpartnerLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userSelectComboBox
            // 
            this.userSelectComboBox.FormattingEnabled = true;
            this.userSelectComboBox.Location = new System.Drawing.Point(84, 10);
            this.userSelectComboBox.Name = "userSelectComboBox";
            this.userSelectComboBox.Size = new System.Drawing.Size(191, 21);
            this.userSelectComboBox.TabIndex = 0;
            // 
            // chatpartnerLabel
            // 
            this.chatpartnerLabel.AutoSize = true;
            this.chatpartnerLabel.Location = new System.Drawing.Point(13, 13);
            this.chatpartnerLabel.Name = "chatpartnerLabel";
            this.chatpartnerLabel.Size = new System.Drawing.Size(65, 13);
            this.chatpartnerLabel.TabIndex = 1;
            this.chatpartnerLabel.Text = "Chatpartner:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(262, 193);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 268);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chatpartnerLabel);
            this.Controls.Add(this.userSelectComboBox);
            this.Name = "Chat";
            this.Text = "W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userSelectComboBox;
        private System.Windows.Forms.Label chatpartnerLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}