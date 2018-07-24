using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CashMachine
{
    public struct User
    {
        public RoleType Role;
        public string UserName;
        public string UserPass;
        public int Balance;
        public bool IsBlocked;
        public int Attempt;
    }
}
