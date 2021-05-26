using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat_DZ_2021_05_31
{
    public abstract class Participant
    {
        protected MyChat ChatRoom { get; set; }

        private string UserName;

        public string Name
        {
            get { return UserName; }
        }

        public Participant(string user, Mediator mediator)
        {
            UserName = user;
            ChatRoom = (MyChat)mediator;
        }

        public void SendMessage(ListBox listBox, string message, CheckBox checkbox)
        {
            if (checkbox.Checked == false)
            {
                //MyChat.SendMessageOneUser()
            }
        }

        public virtual void Notify(string from, string message)
        {
            
        }


    }
}
