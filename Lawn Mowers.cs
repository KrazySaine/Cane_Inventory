using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    //24.00
    public class Lawn_Mowers : IShippable
    {
        private decimal _shipCost = 24.00M;
        private string _product = "Lawn Mower";
        public decimal ShipCost { get { return _shipCost; } }
        public string  Product { get { return _product; } }

        public bool AddToList()
        { return true;
        }
    }
}
