using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater.Players
{
    class UberPlayer : BasePlayer
    {
        int counter;
        public UberPlayer(int minRange, int maxRange) : base(minRange, maxRange)
        {
            counter = MinRange;
        }
        public override int GetWeight()
        {
            return ++counter;
        }
    }
}
