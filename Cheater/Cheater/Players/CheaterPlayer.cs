using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater.Players
{
    class CheaterPlayer : NotePlayer
    {
        public CheaterPlayer(int minRange, int maxRange) : base(minRange, maxRange)
        { }
        public override void SetWeight(int weight)
        {
            if (!IsNumberExist(weight))
            {
                noteArrary[counter] = weight;
                counter++;
            }
        }
    }
}
