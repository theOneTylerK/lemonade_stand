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
        public int WillBuyChance;
        public double spendingCash;
        protected Random rng = new Random();


        //Constructor (Spawner)
        public Customer()
        {
            this.spendingCash = spendingCash;
            this.WillBuyChance = WillBuyChance;
            
        }
        //member methods (Can Do)
        public abstract double BuyLemonade(double lemonadePrice, Day day);
        public abstract double DecideToPurchase(Day day, double sellPrice);

    }
}
