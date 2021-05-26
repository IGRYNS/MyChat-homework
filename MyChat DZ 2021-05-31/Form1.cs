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
    public partial class Form1 : Form
    {
        MyChat myChat = new MyChat();
        


        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            if (user!=null)
            {
                user = user.Trim();
                if (user!="")
                {
                    UserInChat participant = new UserInChat(user, myChat);
                    if(myChat.JoinToChat(participant)==true)
                    {
                        //Chat chat = new Chat { Text = user };                        
                        //chat.Show();
                        myChat.UpdateUserList();
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myChat.KickUserbyName(textBox1.Text);
            myChat.UpdateUserList();
            myChat.SystemMessage(3, textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myChat.CheckUser();
        }
    }
}
