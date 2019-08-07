using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    abstract class Customer
    {
        //member variables (Has A)
        public bool WillBuy;
        public double spendingCash;


        //Constructor (Spawner)
        public Customer()
        {
            this.spendingCash = spendingCash;
            this.WillBuy = WillBuy;
            
        }
        //member methods (Can Do)
        public abstract double BuyLemonade(double lemonadePrice);

    }
}
