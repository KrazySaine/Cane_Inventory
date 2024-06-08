using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    //5.95
    public class Cell_Phones : IShippable
    {
        private decimal _shipCost = 5.95M;
        private string _product = "Cell Phone";
        public decimal ShipCost { get { return _shipCost; } }
        public string Product { get { return _product; } }

        public bool AddToList()
        {
            return true;
        }
    }
}
