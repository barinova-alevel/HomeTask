using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater.Players
{
    class OrdinarPlayer : BasePlayer
    {
        public OrdinarPlayer(int minRange, int maxRange) : base(minRange, maxRange)
        {
            Type = PlayerType.Ordinar;
        }
        public override int GetWeight()
        {
            return new Random().Next(MinRange, MaxRange);
        }
    }
}
