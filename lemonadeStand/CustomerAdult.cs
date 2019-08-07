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
            this.Cash = 5.00;
            this.WillBuy = 40;
        }

        //member methods (Can Do)
        public override void BuyLemonade()
        {
         
        }
    }
}
