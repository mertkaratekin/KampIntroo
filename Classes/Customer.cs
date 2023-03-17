using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //property ==ozellik
        public int Id { get; set; }
        private string _firstName;
        public string FirstName { //encapsulation
            get { return "Mrs."+ _firstName; } 
            set { _firstName = value; } }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
