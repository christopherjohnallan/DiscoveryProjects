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

        public Profile(string blahblah)
        {
            Name = blahblah;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}
