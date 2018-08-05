using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhouse.Items
{
    public class Wire:Item
    {
        public Wire() {
            this.ExpirationDate = 2;
        } 
        public float Price { get; set; }
    }
}
