using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    //3.23
    public class Baseball_Gloves : IShippable
    {
        private decimal _shipCost = 3.23M;
        private string _product = "Baseball Glove";
        public decimal ShipCost { get { return _shipCost; } }
        public string Product { get { return _product; } }

        public bool AddToList()
        {
            return true;
        }
    }
}
