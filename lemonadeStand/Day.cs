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
        public Weather weather = new Weather();



        //Constructor (Spawner)
        public Day()
        {
           
           
        }

        //member methods (Can Do)
        public void ShowActualWeather()
        {
            weather.GetActualWeather();
        }

        public void ShowWeatherForcast()
        {
            weather.GetWeatherForcast();
        }
    }
}
