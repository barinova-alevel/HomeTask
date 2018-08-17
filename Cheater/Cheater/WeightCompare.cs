using Cheater.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater
{
    public class WeightCompare
    {
        int guessWeight;
        BasePlayer[] basePlayer;
        int turnsCount;

        public WeightCompare(int guessWeight, BasePlayer[] basePlayer, int turnsCount)
        {
            this.guessWeight = guessWeight;
            this.basePlayer = basePlayer;
            this.turnsCount = turnsCount;
        }

        public void RunComparator()
        {
            int counter = 0;
            bool isGameEnd = false;

            do
            {
                foreach (BasePlayer pl in this.basePlayer)
                {
                    int weight = pl.GetWeight();
                    if (weight == this.guessWeight)
                    {
                        Console.WriteLine("Winner is {0}, type {1}, weight: {2}", pl.Name, pl.Type, weight);
                        isGameEnd = true;
                        break;
                    }

                    Console.WriteLine("Player {0} with type {1} says is {2}", pl.Name, pl.Type, weight);

                    foreach (BasePlayer plSave in this.basePlayer)
                    {
                        plSave.SetWeight(weight);
                    }
                }

                if (isGameEnd)
                    break;

                counter++;
            } while (counter < this.turnsCount);

            if (!isGameEnd)
            {
                PrintCloseltWinner();
            }
        }

        private void PrintCloseltWinner()
        {
            Console.WriteLine("No winners!!");
        }
    }
}
