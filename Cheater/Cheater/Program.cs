using Cheater.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfPlayers game = new NumberOfPlayers();
            int players = game.GetPlNumber();

            GuessWeight gv = new GuessWeight();
            int weight = gv.Weight(40, 140);

            PlayerInit pi = new PlayerInit(40, 140);
            BasePlayer[] array = pi.GetPlayers(players);


            WeightCompare weightCompare = new WeightCompare(weight, array,100);
            weightCompare.RunComparator();
            Console.WriteLine("change");

            Console.ReadKey();
        }
    }
}
