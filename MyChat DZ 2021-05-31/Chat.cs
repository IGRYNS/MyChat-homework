using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyChat_DZ_2021_05_31
{
    public partial class Chat : Form
    {
       private MyChat mediator = null;

        public Chat(MyChat mediator)
        {
            InitializeComponent();
            this.mediator = mediator;
        }    


        public void UpdateList(List<string> users)
        {
            lbUsersInChat.Items.Clear();
            foreach (var item in users)
            {
                if (item!=this.Text)
                {
                    lbUsersInChat.Items.Add(item);
                }
                
            }
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Tag = Text;
        }


        public void GetMessage(string message)
        {
            tbAllMessages.Text +=  "\r" + "\n" + message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (lbUsersInChat.SelectedItem!=null)
                {
                   mediator.SendMessageOneUser(Text, lbUsersInChat.SelectedItem.ToString(), tbUser.Text);
                    tbUser.Text = "";
                }                
            }
            else
            {
               mediator.SendMessageAllUser(Text, tbUser.Text);
                tbUser.Text = "";
            }

        }
    }

    
}
