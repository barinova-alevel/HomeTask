using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PhoneBook
    {
        public Contact[] BookInitial()
        {
            Contact[] phoneBook = new Contact[2];
            phoneBook[0].PhoneNumber = 1239;
            phoneBook[0].FirstName = "Tim";
            phoneBook[0].LastName = "Lastn";

            phoneBook[1].PhoneNumber = 321654987;
            phoneBook[1].FirstName = "Don";
            phoneBook[1].LastName = "Lname";
            return phoneBook;
        }
            
    }
}
