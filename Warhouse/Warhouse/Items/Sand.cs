using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhouse.Items
{
    public class Sand:Item
    {
        public Sand() {
            this.ExpirationDate = 3;
        }
       
        public float Price { get; set; }
    }
}
