using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Human : Player
    {
        //member variables (Has A)
        public double newCash;

        //Constructor (Spawner)
        public Human()
        {
            
        }

        //Member Methods (Can Do)
        
        public override int SetRecipe(int lemons, int sugar, int ice)
        {
            int FinalRecipe = 1;
            return FinalRecipe;
          
        }
        public override void SetPrice()
        {
           
        }
    }
}
