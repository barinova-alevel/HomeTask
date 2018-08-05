using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhouse.Items;

namespace Warhouse
{
    public class Warehouse
    {

        public Item[] Items { get; }
        public Warehouse()
        {
            Items = new Item[6];
            FillItems();
        }

        public void FillItems()
        {
            Items[0] = new Sand()
            {
                DeliveredDate = DateTime.Now.AddDays(-2),
                Name = "Gray sand",
                Price = 23
            };
            Items[1] = new Sand()
            {
                DeliveredDate = DateTime.Now.AddDays(-3),
                Name = "White sand",
                Price = 45
            };
            Items[2] = new Sand()
            {
                DeliveredDate = DateTime.Now,
                Name = "Black sand",
                Price = 85
            };
            Items[3] = new Wire()
            {
                DeliveredDate = DateTime.Now.AddDays(-1),
                Name = "Strong sand",
                Price = 542
            };
            Items[4] = new Wire()
            {
                DeliveredDate = DateTime.Now.AddDays(-2),
                Name = "Bold sand",
                Price = 42
            };
            Items[5] = new Wire()
            {
                DeliveredDate = DateTime.Now,
                Name = "Think sand",
                Price = 3
            };
        }

        public void PrintExpiredGoods()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Item item = Items[i];
                if (item.IsExprired)
                {
                    Console.WriteLine("Exprired product {0}, expired date {1}", item.Name, item.ExpiredDate);
                }
                else {
                    Console.WriteLine("Can sell {0}", item.Name);
                }
            }
        }
    }
}
