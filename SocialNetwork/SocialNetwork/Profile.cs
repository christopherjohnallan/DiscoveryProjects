using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Profile
    {
        //public string Name {get; set;}
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Date { get; set; }

        // Example 
        //private string _abc;
        //public string ABC
        //{
        //    get { return _abc; }
        //    set
        //    {
        //        if (!String.IsNullOrEmpty(value))
        //        {
        //            _abc = value;
        //        }
        //    }
        //}
        // End Example 

        public List<Profile> Friends { get; set; }
        public List<Profile> PendingFriendRequests { get; set; }
        public List<Profile> IncomingFriendRequests { get; set; }

        public Profile(string name, string date)
        {
            Name = name;
            Friends = new List<Profile>();
            PendingFriendRequests = new List<Profile>();
            Date = date;
        }

        public void AddFriend(Profile friend)
        {
            Friends.Add(friend);
        }

        public void PrintFriendList()
        {
            foreach (Profile friend in Friends)
            {
                Console.WriteLine(friend.Name);
            }
        }

        public void RequestFriend(Profile friend)
        {
            PendingFriendRequests.Add(friend);
            friend.IncomingFriendRequests.Add(this);
        }

        public void PrintPendingFriendRequests()
        {
            foreach (Profile friend in PendingFriendRequests)
            {
                Console.WriteLine(friend.Name);
            }
        }

        public void PrintIncomingFriendRequests()
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name + " my birthday is " + Date);
        }
    }
}
