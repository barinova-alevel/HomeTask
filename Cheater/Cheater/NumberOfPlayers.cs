using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater
{
    class NumberOfPlayers
    {
        public int GetPlNumber()
        {
            return Helper.GetValueInRange(2, 8, "Enter number of players from 2 to 8: ");
        }
    }
}
