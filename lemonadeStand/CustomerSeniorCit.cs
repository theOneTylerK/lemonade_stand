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
            this.Cash = 1.25;
            this.WillBuy = 50;
        }

        //member methods (Can Do)
        public override void BuyLemonade()
        {
            
         
        }
    }
}
