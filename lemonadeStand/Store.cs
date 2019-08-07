using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Store
    {
        //member variables (Has A)
            public double lemonsPrice;
            public double sugarPrice;
            public double cupsPrice;
            public double icePrice;
            public double cart;
        //Constructor (Spawner)
        public Store()
        {
            this.lemonsPrice = 0.15;
            this.sugarPrice = 0.10;
            this.cupsPrice = 0.05;
            this.icePrice = 0.01;
            this.cart = 0.00;

        }

        public int SellItem(Player player, string itemName, double itemPrice)
        {
            Console.WriteLine($"Please enter how many {itemName} you would like to buy.");
            int itemToPurchase = int.Parse(Console.ReadLine());
            double totalPrice = itemToPurchase * itemPrice;

            if(player.Cash < totalPrice)
            {
                Console.WriteLine("You don't have enough money to buy that. Please try again.");
                SellItem(player, itemName, itemPrice);
            }
            else
            {
                player.Cash -= totalPrice;
                cart = totalPrice;
                DisplayMoneySpent(totalPrice, player.Cash);
                
            }

            return itemToPurchase;
        }

        //member methods (Can Do)
        public void SellItems(Player player)
        {
            player.inventory.stockLemons += SellItem(player, "lemons", lemonsPrice);
            player.inventory.DisplayInventory(player.inventory.stockLemons, "lemons");
            player.inventory.stockSugar += SellItem(player, "cups of sugar", sugarPrice);
            player.inventory.DisplayInventory(player.inventory.stockSugar, "sugar");
            player.inventory.stockCups += SellItem(player, "cups", cupsPrice);
            player.inventory.DisplayInventory(player.inventory.stockCups, "cups");
            player.inventory.stockIce += SellItem(player, "ice cubes", icePrice);
            player.inventory.DisplayInventory(player.inventory.stockIce, "ice");
            Console.ReadLine();
            
        }

        public void DisplayMoneySpent(double moneySpent, double playerCash)
        {


            Console.WriteLine("You spent: " + moneySpent
                + Environment.NewLine + "Your total cash is " + playerCash);
        }


    }
}
