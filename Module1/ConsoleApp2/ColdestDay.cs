using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ColdestDay
    {

        public struct MonthDay
        {
            public string Weekday { get; set; }

            public int Temperature { get; set; }


            public void WriteDay()
            {
                Console.WriteLine($"Weekday :{Weekday}, Temperature: {Temperature}");
            }
        }

        public enum Weekday : byte { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public void ShouldPrint(int maxtemprat, int pointToMinusToDisplay)
        {

            MonthDay[] day = new MonthDay[30];

            Contact[] contacts = new Contact[5];
            for (int i = 0; i < contacts.Length; i++)
            {
                contacts[i].PhoneNumber = i * 99;
                contacts[i].FirstName = $"FirstName{i}";
                contacts[i].LastName = $"LastName{i}";

                Errors err = Errors.EmptyBankCard;
                if (i % 2 == 0)
                    contacts[i].BankCard = CardType.Platinum;
                else
                    contacts[i].BankCard = CardType.Gold;
            }

            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].BankCard == CardType.Platinum)
                    contacts[i].WriteContact();
            }

        }
    }
}
