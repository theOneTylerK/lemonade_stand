using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Day
    {
        //member variables (Has A)
        Random rng = new Random();
       


        //Constructor (Spawner)
        public Day()
        {
            Weather weather = new Weather(rng);
           
        }

        //member methods (Can Do)
    }
}
