using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    public interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
        public bool AddToList();
    }
    
    
}
