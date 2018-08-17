using Cheater.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheater
{
    public class PlayerInit
    {
        int minRange;
        int maxRange;
        public PlayerInit(int minRange, int maxRange)
        {
            this.minRange = minRange;
            this.maxRange = maxRange;
        }

        public BasePlayer[] GetPlayers(int count)
        {
            BasePlayer[] players = new BasePlayer[count];
            for (int i = 0; i < count; i++)
            {
              
                Console.WriteLine("Enter player's name");
               string name = Console.ReadLine();
                Console.WriteLine("Enter player's type  (0,1,2,3,4)");
                PlayerType type = (PlayerType)Convert.ToInt32(Console.ReadLine());
                BasePlayer pl = null;
                switch (type)
                {
                    case PlayerType.Cheater:
                        pl = new CheaterPlayer(minRange,maxRange);
                        break;
                    case PlayerType.Note:
                        pl = new NotePlayer(minRange,maxRange);
                        break;
                    case PlayerType.Ordinar:
                        pl = new OrdinarPlayer(minRange,minRange);
                        break;
                    case PlayerType.Uber:
                        pl = new UberPlayer(minRange,maxRange);
                        break;
                    case PlayerType.UberCheater:
                        pl = new UberCheaterPlayer(minRange,maxRange);
                        break;
                }

                pl.Type = type;
                pl.Name = name;
                players[i] = pl;
               

            }
            return players;
        }
    }
}
