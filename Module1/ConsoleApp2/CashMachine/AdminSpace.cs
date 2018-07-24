using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CashMachine
{
    public class AdminSpace
    {
        User[] copyUsers;
        public AdminSpace(User[] users)
        {
            copyUsers = users;
        }


        public void InitMenu()
        {
            int exitCall = -22;
            while (exitCall != 0)
            {
                Console.WriteLine("Select one of options:\n1. Add user\n2.Remove User\n3. Unblock User\n4. Print User List\n5. Logout\n");
                Console.Write("Choose the option:");
                string keyCode = Console.ReadLine();

                switch (keyCode)
                {
                    case "1":
                        AddUser();
                        break;

                    case "2":
                        RemoveUser();
                        break;

                    case "3":
                        UnblokUser();
                        break;

                    case "4":
                        PrintUserList();
                        break;

                    case "5":
                        exitCall = 0;
                        break;

                    default:
                        Console.WriteLine("Wrong option, try again!!! /n");
                        break;

                }
            }

        }

        private void AddUser()
        {
            Console.WriteLine("Write name of new user\n");
            string name = Console.ReadLine();
            string password = name;
            for (int i = 0; i < copyUsers.Length; i++)
            {
                User u = copyUsers[i];
                if (string.IsNullOrEmpty(u.UserName))
                {
                    u.UserName = name;
                    u.UserPass = password;
                    u.Balance = 100;
                    u.Role = RoleType.Client;
                    copyUsers[i] = u;
                    break;
                }
            }

        }

        private void RemoveUser()
        {
            Console.WriteLine("Write name of the user to remove\n");
            string name = Console.ReadLine();

            for (int i = 0; i < copyUsers.Length; i++)
            {
                User u = copyUsers[i];
                if (u.UserName == name)
                {
                    copyUsers[i] = default(User);
                    break;
                }
            }

        }

        private void PrintUserList()
        {
            for (int i = 0; i < copyUsers.Length; i++)
            {
                if (!string.IsNullOrEmpty(copyUsers[i].UserName))
                    Console.WriteLine("\nuser Name: {0}| Balance: {1}", copyUsers[i].UserName, copyUsers[i].Balance);
            }
        }

        private void UnblokUser()
        {
            Console.WriteLine("\nWrite user name for unblock: ");
            string name = Console.ReadLine();

            for (int i = 0; i < copyUsers.Length; i++)
            {
                User u = copyUsers[i];
                if (u.UserName == name)
                {
                    u.IsBlocked = false;
                    u.Attempt = 0;
                    copyUsers[i] = u;
                    break;
                }
            }
        }
    }
}