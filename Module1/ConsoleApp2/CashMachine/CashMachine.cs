using ConsoleApp2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CashMachine
{
    class CashMachine
    {
        User[] users;
        User currentUser;
        public void InitUsers()
        {
            users = new User[100];
            User u = users[0];
            u.Role = RoleType.Admin;
            u.UserName = "Vasya";
            u.UserPass = "1111";
            u.Balance = 100;
            users[0] = u;
        }

        public bool CheckUserName(string usName)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].UserName == usName)
                {
                    return true;
                }
            }
            return false;
            //throw new UserNotFoundException("Our user wasn't found");
        }
        public bool LoginUser(string usLogin, string usPass)
        {
            for (int i = 0; i < users.Length; i++)
            {
                User u = users[i];
                if (u.UserName == usLogin)
                {

                    if (u.IsBlocked)
                    {
                        Console.WriteLine("Account is blocked. Call to admin");
                        return false;
                    }

                    if (u.UserPass == usPass)
                    {
                        currentUser = u;
                        u.Attempt = 0;
                        return true;

                    }
                    else
                    {
                        u.Attempt++;
                        if (u.Attempt > 3 && u.Role == RoleType.Client)
                            u.IsBlocked = true;
                        return false;
                    }
                }
                users[i] = u;
            }
            return false;
        }

        public void MySpace()
        {
            Console.WriteLine("You are in my Space: {0}", currentUser.UserName);
            if (currentUser.Role == RoleType.Admin)
            {
                new AdminSpace(users).InitMenu();
            }
            else
            {
                AttempToChangePassword();
                ClientSpace userCpace = new ClientSpace(currentUser);
                userCpace.InitMenu();

                currentUser = userCpace.GetUser();
                UpdateCurrentUser();


            }

            currentUser = default(User);
        }

        private void AttempToChangePassword()
        {
            if (currentUser.UserName == currentUser.UserPass)
            {
                Console.WriteLine("Put new password here");
                string newPassword = Console.ReadLine();
                currentUser.UserPass = newPassword;
                UpdateCurrentUser();
            }
        }

        public void UpdateCurrentUser()
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].UserName == currentUser.UserName)
                    users[i] = currentUser;
            }
        }

        public int Login()
        {
            int exValue = -22;
            while (exValue != 0)
            {
                Console.WriteLine("Enter Login: ");
                string usLogin = Console.ReadLine();
                if (CheckUserName(usLogin))
                {
                    Console.WriteLine("Enter password ");
                    string usPass = Console.ReadLine();
                    if (LoginUser(usLogin, usPass))
                    {
                        MySpace();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password. Press 1 to exit\n Press any key to continue  ");
                        string usValue = Console.ReadLine();
                        if (usValue == "1")
                        {
                            exValue = Exit();
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Login. Press 1 to exit\n Press any key to continue  ");
                    string usValue = Console.ReadLine();
                    if (usValue == "1")
                    {
                        exValue = Exit();
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            return 0;
        }

        public int Exit() { return 0; }

        public void Init()
        {
            InitUsers();

            Console.WriteLine("Select action: \n To Login set 1\n To exit set 2");
            int exitCall = -22;
            while (exitCall != 0)
            {
                string userValue = Console.ReadLine();
                if (userValue == "1" || userValue == "2")
                {
                    if (userValue == "1")
                        exitCall = Login();
                    else
                        exitCall = Exit();
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2");
                }
            }
        }

    }

}
