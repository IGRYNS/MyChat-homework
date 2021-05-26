namespace MyChat_DZ_2021_05_31
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
            this.tbAllMessages = new System.Windows.Forms.TextBox();
            this.lbUsersInChat = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAllMessages
            // 
            this.tbAllMessages.Location = new System.Drawing.Point(140, 11);
            this.tbAllMessages.Multiline = true;
            this.tbAllMessages.Name = "tbAllMessages";
            this.tbAllMessages.ReadOnly = true;
            this.tbAllMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAllMessages.Size = new System.Drawing.Size(242, 195);
            this.tbAllMessages.TabIndex = 0;
            // 
            // lbUsersInChat
            // 
            this.lbUsersInChat.FormattingEnabled = true;
            this.lbUsersInChat.Location = new System.Drawing.Point(12, 11);
            this.lbUsersInChat.Name = "lbUsersInChat";
            this.lbUsersInChat.Size = new System.Drawing.Size(122, 264);
            this.lbUsersInChat.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 288);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Message to all users";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(140, 212);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(242, 63);
            this.tbUser.TabIndex = 4;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbUsersInChat);
            this.Controls.Add(this.tbAllMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAllMessages;
        private System.Windows.Forms.ListBox lbUsersInChat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbUser;
    }
}