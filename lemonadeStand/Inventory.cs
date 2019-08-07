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
        public int stockLemons;
        public int stockSugar;
        public int stockCups;
        public int stockIce;


        //Constructor (Spawner)
        public Inventory()
        {
            stockLemons = 0;
            stockSugar = 0;
            stockCups = 0;
            stockIce = 0;
        }

        //member methods (Can Do)
        public void DisplayInventory(int stockItem, string itemName)
        {
            Console.WriteLine($"You have {stockItem} {itemName} in your inventory");
            Console.ReadLine();
            
        }
        public void AddSugar(int sugarBought)
        {
            stockSugar += sugarBought;
        }
        public void AddCups(int cupsBought)
        {
            stockCups += cupsBought;
        }
        public void AddIce(int iceBought)
        {
            stockIce += iceBought;
        }
    }
}
