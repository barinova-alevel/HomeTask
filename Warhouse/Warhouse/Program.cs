using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhouse
{
    class Program
    {
        static void Main(string[] args)
        {

            Warehouse warehouse = new Warehouse();
            warehouse.PrintExpiredGoods();
            Console.ReadKey();
        }
    }
}
