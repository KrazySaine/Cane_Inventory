using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    //9.50
    public class Bicycles : IShippable
    {
        private decimal _shipCost = 9.50M;
        private string _product = "Bicycle";
        public decimal ShipCost { get { return _shipCost; } }
        public string Product { get { return _product; } }

        public bool AddToList()
        {
            return true;
        }
    }
}
