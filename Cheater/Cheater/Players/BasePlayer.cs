using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater.Players
{
    public abstract class BasePlayer
    {
        public BasePlayer(int minRange, int maxRange)
        {
            this.MinRange = minRange;
            this.MaxRange = maxRange;
        }
        public string Name { get; set; }
        public PlayerType Type { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public abstract int GetWeight();
        public virtual void SetWeight(int weight)
        {
            
        }
    }
}
