using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_shop
{
    internal class product
    {
        public string productName;
        public string ID;
        public string Price;
        public string Unit;

        public string stFullInfo()
        {
            return productName + "@" + ID + "@" + Price + "@" + Unit; 
        }
    }
}
