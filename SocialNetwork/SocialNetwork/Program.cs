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
            Profile user1 = new Profile("Sam", "10/17/1985");
            Profile user2 = new Profile("Chris", "00/00/0000");
            Profile user3 = new Profile("Rob", "00/00/0000");
            //Birthday user1 = new Birthday(1985, 10, 17);

            user1.RequestFriend(user2);
            user1.PrintPendingFriendRequests();
            user1.PrintFriendList();
            user2.PrintIncomingFriendRequests();

            //user1.AddFriend(user2);
            //user1.AddFriend(user3);
            //user1.SayHello();

            //DateTime birthday = new DateTime(1985, 10, 17);
            //birthday = birthday.AddDays(1);
            //Console.WriteLine(birthday.DayOfWeek);

            //Console.WriteLine(birthday.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
