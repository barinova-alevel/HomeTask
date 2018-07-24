using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Exceptions
{
    public class UserNotFoundException:ArgumentException
    {
        public UserNotFoundException(string message) : base(message) { }
    }
}
