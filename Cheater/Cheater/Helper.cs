using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater
{
    public static class Helper
    {
        public static int GetValueInRange(int minRange, int maxRange, string message)
        {
            int enteredValue;
            do
            {
                Console.WriteLine(message);
                enteredValue = Convert.ToInt32(Console.ReadLine());
            }
            while (minRange > enteredValue || maxRange < enteredValue);
            return enteredValue;

        }
    }
}
