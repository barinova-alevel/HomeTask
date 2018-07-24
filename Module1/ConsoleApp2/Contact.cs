using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct Contact
    {
        public int PhoneNumber;
        public string FirstName;
        public string LastName;
        public CardType BankCard;

        public void OutputFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            
        }

        public void OutputFullContact()
        {
            Console.WriteLine($"{PhoneNumber}, {FirstName} {LastName}");
        }

        public void WriteContact() {
            Console.WriteLine("Put First Name");
           FirstName = Console.ReadLine();

            Console.WriteLine("Put Last Name");
            LastName = Console.ReadLine();

            Console.WriteLine("Put Phone number");
            PhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Put Bank Card");
            BankCard = (CardType)int.Parse(Console.ReadLine());

        }
    }
}
