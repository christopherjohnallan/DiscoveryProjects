﻿using System;
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
            Profile user1 = new Profile("Sam", "10/17/1985");
            Profile user2 = new Profile("Chris", "00/00/0000");
            Profile user3 = new Profile("Rob", "00/00/0000");
            //Birthday user1 = new Birthday(1985, 10, 17);
            user1.AddFriend(user2);
            user1.AddFriend(user3);
            user1.PrintFriendList();
            user1.SayHello();
        }
    }
}
