using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGroup
{
    class ChatGroup
    {
        private List<User> users = new List<User>();
        public event EventHandler<ChatEventArgs> AddNotify;
        public event EventHandler<ChatEventArgs> LeaveNotify;
        public event EventHandler<ChatEventArgs> MessageNotify;

        public void LeaveMember(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);

                AddNotify -= user.OnMemberAdd;
                MessageNotify -= user.OnMessage;
                LeaveNotify -= user.OnMemberLeave;

                if (LeaveNotify != null)
                {
                    LeaveNotify(this, new ChatEventArgs(user));
                }
            }
            
        }
        public void AddMember(User user)
        {

            if (users.Count() < 10)
            {
                var observers = 0;
                foreach (User u in users)
                {
                    if (u.GetType() == typeof(Observer))
                        observers++;
                }
                if (observers < 2 || user.GetType() != typeof(Observer))
                {
                    users.Add(user);

                    if (AddNotify != null)
                    {
                        AddNotify(this, new ChatEventArgs(user));
                    }

                    AddNotify += user.OnMemberAdd;
                    MessageNotify += user.OnMessage;
                    LeaveNotify += user.OnMemberLeave;
                }
                else
                    Console.WriteLine("Error. You already have 2 observer in this group");
            }
            else
                Console.WriteLine("Error. You already have 10 member in this group");


        }
        public void SandMessage(Chat chat)
        {
            if (chat.user.GetType() == typeof(ActiveUser) && users.Contains(chat.user))
            {
                if (MessageNotify != null)
                {
                    MessageNotify(this, new ChatEventArgs(chat.user,chat));
                }
            }
            else
                Console.WriteLine("Just an active member can send message");
        }
    }
}
