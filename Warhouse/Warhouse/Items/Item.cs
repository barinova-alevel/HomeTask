using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhouse.Items
{
    public class Item
    {
        public string Name { get; set; }
        public DateTime DeliveredDate { get; set; }
        public int ExpirationDate { get; set; }
        public bool IsExprired
        {
            get
            {
                return DateTime.Now.Subtract(this.DeliveredDate).Days >= ExpirationDate;
            }
        }

        public DateTime ExpiredDate
        {
            get
            {
                return DeliveredDate.AddDays(ExpirationDate);
            }
        }
    }

}

