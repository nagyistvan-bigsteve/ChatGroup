using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    class ActiveUser : User
    {

        public ActiveUser(string name) : base(name) 
        {

        }

        public override void OnMemberAdd(object source, ChatEventArgs args)
        {
            Console.WriteLine($"{Name} has been notified that the {args.User.Name} has been added");
        }
        public override void OnMemberLeave(object source, ChatEventArgs args)
        {
            Console.WriteLine($"{Name} has been notified that the {args.User.Name} has been leave this group");
        }

        public override void OnMessage(object source, ChatEventArgs args)
        {
            if(args.User != this)
                Console.WriteLine($"{Name} get the message: \n {args.Chat.GetTitle()}");
        }
    }
}
