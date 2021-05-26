using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChat_DZ_2021_05_31
{
    public abstract class Mediator
    {
        public abstract void SendMessageOneUser(string FromUser, string ToUser, string Message);
        public abstract void SendMessageAllUser(string FromUser, string Message);
        public abstract void Remove(string user);
        public abstract bool JoinToChat(UserInChat User);

        public abstract void UpdateUserList();

        public abstract void KickUserbyName(string username);

        public abstract void CheckUser();

        public abstract void SystemMessage(int code, string message);

    }
}
