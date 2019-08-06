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
            public double lemons;
            public double sugar;
            public double cups;
            public double ice;
            public double cart;
        //Constructor (Spawner)
        public Store()
        {
            this.lemons = 0.15;
            this.sugar = 0.10;
            this.cups = 0.02;
            this.ice = 1.25;
            this.cart = 0.00;

            
            
        }

        public int SellLemons()
        {
            Console.WriteLine("Please enter how many lemons you would like to buy.");
            int userLemons = int.Parse (Console.ReadLine());
            //try
            //{
            //    userLemons = 
            //}
            return userLemons;
        }
        public int SellSugar()
        {
            Console.WriteLine("Please enter how many cups of sugar you would like to buy.");
            int userSugar = int.Parse (Console.ReadLine());
            return userSugar;
        }
        public int SellCups()
        {
            Console.WriteLine("Please enter how many cups you would like to buy.");
            int userCups = int.Parse(Console.ReadLine());
            return userCups;
        }
        public int SellIce()
        {
            Console.WriteLine("Please enter how many bags of ice you would like to buy.");
            int userIce = int.Parse(Console.ReadLine());
            return userIce;
        }
        //member methods (Can Do)
        public double SellItems(Player player)
        {
                    double lemonSales = SellLemons() * lemons;
                    double sugarSales = SellSugar() * sugar;
                    double cupsSales = SellCups() * cups;
                    double iceSales = SellIce() * ice;
            cart = lemonSales + sugarSales + cupsSales + iceSales;
            Console.WriteLine("Your total is " + cart);
            Console.ReadLine();
            return cart;
        }

        public double TakePayment(Player player)
        {
            if(player.Cash < cart)
            {
                Console.WriteLine("You don't have enough money to buy all that. Please try again.");
                SellItems(player);
            }
            double MoneySpent = player.Cash - cart;
            Console.WriteLine("You spent: " + cart
                + Environment.NewLine + "Your total cash is " + MoneySpent);
            return MoneySpent;

        }


    }
}
