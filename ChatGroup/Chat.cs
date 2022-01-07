using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    class Chat
    {
        public User user;
        public string message;

        public Chat(User user, string message)
        {
            this.user = user;
            this.message = message;
        }

        public string GetTitle() => $"{user.Name} said -> {message}";
    }
}
