using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    // contact class creates a base for 
    // items which we have to store as for 
    public  class contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zipcode { get; set; }

        public string emailid { get; set; }

        public string phonenumber { get; set; }
    }
}
