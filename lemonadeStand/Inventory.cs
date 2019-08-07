using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Inventory
    {
        //member variables (Has A)
        public double stockLemons;
        public double stockSugar;
        public double stockCups;
        public double stockIce;


        //Constructor (Spawner)
        public Inventory()
        {
            stockLemons = 0;
            stockSugar = 0;
            stockCups = 0;
            stockIce = 0;
        }

        //member methods (Can Do)
        public void DisplayInventory(double stockItem, string itemName)
        {
            Console.WriteLine($"You have {stockItem} {itemName} in your inventory");
            Console.ReadLine();
            
        }
       
        

        
    }
}
