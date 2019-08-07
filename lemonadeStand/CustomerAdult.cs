using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CustomerAdult : Customer
    {
        //member variables (Has A)

        //Constructor (Spawner)
        public CustomerAdult()
        {
            this.spendingCash = 5.00;
            this.WillBuy = false;
        }

        //member methods (Can Do)
        public override double BuyLemonade(double lemonadePrice)
        {
            if (lemonadePrice > spendingCash)
            {
                WillBuy = false;
                double sellprice = 0.00;
                Console.WriteLine("Too Expensive");
                return sellprice;
            }
            else
            {
                WillBuy = true;
                Console.WriteLine("Yum");
                return lemonadePrice;
            }



        }
    }
}
