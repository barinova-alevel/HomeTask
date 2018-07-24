using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CashMachine
{
    public class ClientSpace
    {
        User currentUser;

        public ClientSpace(User user)
        {
            currentUser = user;
        }

        public User GetUser()
        {
            return currentUser;
        }

        public void InitMenu()
        {
            int exitCall = -22;
            while (exitCall != 0)
            {
                Console.WriteLine("Select one of options:\n1. Show balance\n2. Charge money \n3. Top ballance up\n4. Logout");
                Console.Write("Chouse the option:");
                string keyCode = Console.ReadLine();

                switch (keyCode)
                {
                    case "1":
                        ShowBalance();
                        break;

                    case "2":
                        ChargeMoney();
                        break;

                    case "3":
                        TopUp();
                        break;

                    case "4":
                        exitCall = 0;
                        break;

                    default:
                        Console.WriteLine("Wrong option, try again!!!");
                        break;

                }
            }

        }

        private void ShowBalance()
        {
            Console.WriteLine("Your balance: {0}", currentUser.Balance);
        }

        private void ChargeMoney()
        {

            Console.WriteLine("Charge ammount of money:");
            int newBalance = int.Parse(Console.ReadLine());
            if (currentUser.Balance < newBalance)
            {
                Console.WriteLine("Your balance isn't enough");
                return;
            }

            currentUser.Balance -= newBalance;
            
            ShowBalance();
        }

        private void TopUp()
        {

            Console.WriteLine("Put top up ammount:");
            int newBalance = int.Parse(Console.ReadLine());
            currentUser.Balance += newBalance;
            ShowBalance();
        }
    }
}
