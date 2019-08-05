using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
   abstract class Player
    {
   //member variables (Has A)

   //Constructor (Spawner)


   //Member Methods (Can Do)
        public abstract void MakePurchase();

        public abstract int SetRecipe(int lemons, int sugar, int ice);

        public abstract void SetPrice();
        
    }

}
