using System;

namespace ChatGroup
{
    class Program
    {
        //Observer DP
        static void Main(string[] args)
        {
            var group = new ChatGroup();

            var peti = new Observer("Peti");
            var jasmin = new Observer("Jasmin");
            var david = new Observer("David");
            var pisti = new ActiveUser("Pisti");
            var karcsi = new ActiveUser("Karcsi");
            var piri = new ActiveUser("Piri");
            var patrik = new ActiveUser("Patrik");
            var petra = new ActiveUser("Petra");
            var karola = new ActiveUser("Karola"); 
            var kris = new ActiveUser("Kris");
            var lara = new ActiveUser("Lara");
            var mara = new ActiveUser("Mara");


            group.AddMember(peti);
            group.AddMember(jasmin);
            group.AddMember(david);

            group.LeaveMember(jasmin);
            group.AddMember(david);

            group.AddMember(pisti);
            group.AddMember(karcsi);
            group.AddMember(piri);
            group.AddMember(patrik);
            group.AddMember(petra);
            group.AddMember(karola);
            group.AddMember(kris);
            group.AddMember(lara);
            group.AddMember(mara);


            group.SandMessage(new Chat(kris, "sziasztok"));
            group.SandMessage(new Chat(peti, "sziasztok"));
        }
    }
}
