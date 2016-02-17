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
        public List<Profile> Friends { get; set; }

        public Profile(string name)
        {
            Name = name;
            Friends = new List<Profile>();
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

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}
