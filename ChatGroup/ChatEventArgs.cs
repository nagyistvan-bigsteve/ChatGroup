using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    class ChatEventArgs
    {
        public ChatEventArgs(User user,Chat chat)
        {
            User = user;
            Chat = chat;
        }
        public ChatEventArgs(User user)
        {
            User = user;
        }

        public Chat Chat { get; private set; }
        public User User { get; private set; }
    }
}
