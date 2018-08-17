using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater
{
    //Basket weight that players are guessing
    class GuessWeight
    {
        
        public int Weight(int minRange, int maxRange)
        {
            return Helper.GetValueInRange(minRange, maxRange, "Enter weight within the range from " +minRange+ " to " +maxRange);

        }
    }
}
