using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater.Players
{
    class NotePlayer : BasePlayer
    {
        protected int[] noteArrary;
        protected int counter = 0;
        public NotePlayer(int minRange, int maxRange):base(minRange,maxRange)
        {
            noteArrary = new int[MaxRange - MinRange]; //weight (140-40)
        }
        public override int GetWeight()
        {
            int value = 0;
            do
            {
                value = new Random().Next(MinRange, MaxRange);
            } while (IsNumberExist(value));

            noteArrary[counter] = value;
            counter++;
            return value;
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
