using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_Inventory
{
    public class Shipper : IShipCalc
    {
        public decimal Add()
         {
           int[IShippable] cost = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           int sum = 0;
           sum = cost.Sum();
           return sum;
         }
        
    }
}
