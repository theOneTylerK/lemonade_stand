using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CustomerChild : Customer
    {
        //member variables (Has A)

        //Constructor (Spawner)
        public CustomerChild()
        {
            this.Cash = 0.20;
            this.WillBuy = 75;
        }

        //member methods (Can Do)
        public override void BuyLemonade()
        {

            
        }
    }
}
