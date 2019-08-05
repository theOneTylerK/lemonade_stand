using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Weather
    {
        //member variables (Has A)
        public int Temperature;


        //Constructor (Spawner)
        Random rng = new Random();
        


        //member methods (Can Do)
        public int ChooseTemperature(int min, int max)
        {
            return rng.Next(min, max);

        }
    }
}
