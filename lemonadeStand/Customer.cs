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
        public int WillBuy;
        public double Cash;


        //Constructor (Spawner)
        public Customer()
        {
            this.Cash = Cash;
            this.WillBuy = WillBuy;
            
        }
        //member methods (Can Do)
        public abstract void BuyLemonade();

    }
}
