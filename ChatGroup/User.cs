using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    abstract class User
    {
        public string Name;

        public User(string name)
        {
            Name = name;
        }

        public abstract void OnMemberAdd(object source, ChatEventArgs args);
        public abstract void OnMemberLeave(object source, ChatEventArgs args);
        public abstract void OnMessage(object source, ChatEventArgs args);
    }
}
