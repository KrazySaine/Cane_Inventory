using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

namespace Cane_Inventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IShippable[] shipList = new IShippable[10];
            
            for (int i = 0; i < shipList.Length; i++)
            {
                shipList[i] = new IShippable();
            }
            {
                Console.WriteLine("Choose from the following options:\n");
                Console.WriteLine("1. Add a Bicycle to the shipment\n");
                Console.WriteLine("2. Add a Lawn Mower to the shipment\n");
                Console.WriteLine("3. Add a Baseball Glove to the shipment\n");
                Console.WriteLine("4. Add Crackers to the shipment\n");
                Console.WriteLine("5. List Shipment Items\n");
                Console.WriteLine("6. Compute Shipping Charges\n");
                Console.WriteLine("Exit\n");

                int option = Console.Read();

                switch (option)
                {
                    case 1:
                        shipList[shipList.Length + 1] = new Bicycles();
                        Console.WriteLine("1 Bicycle has been added...");
                        break;
                    case 2:
                        shipList[shipList.Length + 1] = new Lawn_Mowers();
                        Console.WriteLine("1 Lawn Mower has been added...");
                        break;
                    case 3:
                        shipList[shipList.Length + 1] = new Baseball_Gloves();
                        Console.WriteLine("1 Baseball Glove has been added...");
                        break;
                    case 4:
                        shipList[shipList.Length + 1] = new Crackers();
                        Console.WriteLine("1 Crackers has been added...");
                        break;
                    case 5:
                        Console.WriteLine("Items in Shipping List are " +shipList.Length);
                        break;
                    case 6:
                        Console.WriteLine("Items in Shipping List are " + shipList.Length + "\n");
                        //Console.WriteLine("Cost to ship products is $" + IShipCalc.Add() + "\n");
                        break;
                    default:

                        break;
                }

                

                
                //process user input
                
            }
        }
    }
}
