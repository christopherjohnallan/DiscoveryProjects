using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile user1 = new Profile("Sam");
            Profile user2 = new Profile("Chris");
            Profile user3 = new Profile("Rob");
            user1.AddFriend(user2);
            user1.AddFriend(user3);
            user1.PrintFriendList();
        }
    }
}
