using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    //0.57 ship cost
    public class Crackers : IShippable
    {
        private decimal _shipCost = 0.57M;
        private string _product = "Crackers";
        public decimal ShipCost { get { return _shipCost; } }
        public string Product { get { return _product; } }

        public bool AddToList()
        {
            return true;
        }
    }
}
