﻿using System;
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
            Console.WriteLine($"You added {stockItem} {itemName} to your inventory");
            
            
        }
       
        public void DisplayInventory(double StockItem, string itemName, double StockItem2, string itemName2, double StockItem3, string itemName3, double StockItem4, string itemName4)
        {
            if(StockItem < 0)
            {
                StockItem = 0;
            }
            if (StockItem2 < 0)
            {
                StockItem2 = 0;
            }
            if (StockItem3 < 0)
            {
                StockItem3 = 0;
            }
            if (StockItem4 < 0)
            {
                StockItem4 = 0;
            }
            Console.WriteLine($"You currently have" + Environment.NewLine +
                $"{StockItem} {itemName}" + Environment.NewLine +
                $"{StockItem2} {itemName2}" +Environment.NewLine +
                $"{StockItem3} {itemName3}" + Environment.NewLine +
                $"{StockItem4} {itemName4} in your inventory");
        }

        
    }
}
