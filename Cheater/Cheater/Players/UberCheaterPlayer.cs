using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater.Players
{
    class UberCheaterPlayer : BasePlayer
    {
        protected int[] noteArrary;
        protected int counter = 0;
        private int currentWeight;

        public UberCheaterPlayer(int minRange, int maxRange) : base(minRange, maxRange)
        {
            noteArrary = new int[MaxRange - MinRange];
            currentWeight = MinRange;
        }

        public override int GetWeight()
        {
            do
            {
                currentWeight++;
            } while (IsNumberExist(currentWeight));

            noteArrary[counter] = currentWeight;
            counter++;
            return currentWeight;
        }

        public override void SetWeight(int weight)
        {
            if (!IsNumberExist(weight))
            {
                noteArrary[counter] = weight;
                counter++;
            }
        }

        protected bool IsNumberExist(int value)
        {
            for (int i = 0; i < counter; i++)
            {
                if (noteArrary[i] == value)
                    return true;
            }
            return false;
        }
    }
}
