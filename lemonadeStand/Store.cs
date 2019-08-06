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

            CalculateTotal();
            TakePayment();
        }




        //member methods (Can Do)
        public double CalculateTotal()
        {
            Console.WriteLine("Lemons are on sale for $0.15 per lemon. How many lemons would you like to buy?");
                string userLemons = Console.ReadLine();
                    double lemonSales = int.Parse(userLemons) * lemons;
            Console.WriteLine("Sugar is on sale for $0.10 per cup. How many cups of sugar would you like to buy?");
                string userSugar = Console.ReadLine();
                    double sugarSales = int.Parse(userSugar) * sugar;
            Console.WriteLine("Cups are on sale for $0.02 per cup. How many cups would you like to buy?");
                string userCups = Console.ReadLine();
                    double cupsSales = int.Parse(userCups) * cups;
            Console.WriteLine("Ice is on sale for $1.25 per bag of 100 cubes. How many bags of ice would you like to buy?");
                string userIce = Console.ReadLine();
                    double iceSales = int.Parse(userIce) * ice;
            cart = lemonSales + sugarSales + cupsSales + iceSales;
            Console.WriteLine("Your total is " + cart);
            Console.ReadLine();
            return cart;
        }

        public double TakePayment()
        {
            Human buyer = new Human();
            double MoneySpent = buyer.Cash - cart;
            Console.WriteLine("You spent: " + cart
                + Environment.NewLine + "Your total cash is " + MoneySpent);
            return MoneySpent;

        }


    }
}
