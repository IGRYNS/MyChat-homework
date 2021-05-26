using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChat_DZ_2021_05_31
{
   public class UserInChat : Participant
    {


        public UserInChat(string name, Mediator mediator) : base(name, mediator) { }

        public override void Notify(string from, string message)
        {
            base.Notify(from, message);
        }

    }
}
