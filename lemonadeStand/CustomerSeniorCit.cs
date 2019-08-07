using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CustomerSeniorCit :Customer
    {
        //member variables (Has A)
        
        //Constructor (Spawner)
        public CustomerSeniorCit()
        {
            this.spendingCash = 1.25;
            this.WillBuy = false;
        }

        //member methods (Can Do)
        public override double BuyLemonade(double lemonadePrice)
        {
            if(lemonadePrice > spendingCash)
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
