using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat_DZ_2021_05_31
{
    //concrete mediator
    public class MyChat : Mediator
    {
        private Dictionary<string, UserInChat> usersInChat = new Dictionary<string, UserInChat>();
        List<Form> forms = new List<Form>();


        //List<string> Users = new List<string>();

        public override bool JoinToChat(UserInChat user)
        {
            if (!usersInChat.ContainsKey(user.Name))
            {
                usersInChat[user.Name] = user;
                //user.ChatRoom = this;
                

                Chat chat = new Chat(this) { Text = user.Name};
                forms.Add(chat);
                chat.Show();
                SystemMessage(1, user.Name);
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь с таким никнеймом уже существует");
                return false;
            }
            
        }

        public override void Remove(string User)
        {
            throw new NotImplementedException();
        }

        public override void SendMessageAllUser(string FromUser, string Message)
        {
            foreach (Form item in forms)
            {
                (item as Chat).GetMessage($"{DateTime.Now.Hour}:{DateTime.Now.Minute} {FromUser}: " + Message);
            }
        }

        public override void SendMessageOneUser(string FromUser, string ToUser, string Message)
        {
            //UserInChat To = usersInChat[ToUser];
            //if (To != null)
            //{
            //    To.Notify(FromUser, Message);
            //}

            foreach (Form item in forms)
            {
                if (item.Text == FromUser)
                {
                    (item as Chat).GetMessage($"{DateTime.Now.Hour}:{DateTime.Now.Minute} Личное сообщение пользователю '{ToUser}': " + Message);
                }
            }

            foreach (Form item in forms)
            {
                if (item.Text == ToUser)
                {
                    (item as Chat).GetMessage($"{DateTime.Now.Hour}:{DateTime.Now.Minute} Личное сообщение от '{FromUser}': " + Message);
                }
            }
            
        }

        public override void UpdateUserList()
        {
            List<string> names = new List<string>();
            foreach (var item in usersInChat)
            {
                names.Add(item.Key);
            }

            for (int i = 0; i < forms.Count; i++)
            {
                (forms[i] as Chat).UpdateList(names);
            }
        }

        public override void KickUserbyName(string username)
        {
            usersInChat.Remove(username);
            for (int i = 0; i < forms.Count; i++)
            {
                if (forms[i].Text==username)
                {
                    forms[i].Close();
                    forms.RemoveAt(i);
                    return;
                }
            }
        }


        public override void CheckUser()
        {
            for (int i = 0; i < forms.Count; i++)
            {
                if (forms[i].Tag !=null)
                {
                    SystemMessage(2, (string)forms[i].Tag);
                    usersInChat.Remove((string)forms[i].Tag);
                    forms.RemoveAt(i);
                    this.UpdateUserList();
                    
                }
            }
        }

        public override void SystemMessage(int code, string message)
        {
            foreach (Chat item in forms)
            {
                if (code == 1)
                {
                    item.GetMessage($"{DateTime.Now.Hour}:{DateTime.Now.Minute} Пользователь {message} вошел в чат.");
                }
                else if (code == 2)
                {
                    item.GetMessage($"{DateTime.Now.Hour}:{DateTime.Now.Minute} Пользователь {message} вышел из чата.");
                }
                else if (code == 3)
                {
                    item.GetMessage($"{DateTime.Now.Hour}:{DateTime.Now.Minute} Пользователь {message} был кикнут.");
                }
            }
        }
    }
}
