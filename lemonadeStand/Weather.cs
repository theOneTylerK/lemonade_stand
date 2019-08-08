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
        public int forcastTemperature;
        public int actualTemperature;
        public string forcastOvercast;
        public string actualOvercast;
        //Random rng = new Random();
        List<string> overcast = new List<string>();
        


        //Constructor (Spawner)
        public Weather()
        {
            overcast.Add("Sunny");
            overcast.Add("Partly Sunny");
            overcast.Add("Cloudy");
            overcast.Add("Partly Cloudy");
            overcast.Add("Rainy");

           
            
        }
        
        


        //member methods (Can Do)
        public int ChooseTemperature(Random rng, int min, int max)
        {

            int TempChoice = rng.Next(min, max);
            return TempChoice;

        }

        public string ChooseOvercast(Random rng)
        {
            int CurrentOvercast = rng.Next(overcast.Count);
            string OvercastChoice = CurrentOvercast.ToString();
            switch (OvercastChoice)
            {
                case "0":
                    OvercastChoice = "Sunny";
                        break;
                case "1":
                    OvercastChoice = "Partly Sunny";
                        break;
                case "2":
                    OvercastChoice = "Cloudy";
                    break;
                case "3":
                    OvercastChoice = "Partly Cloudy";
                    break;
                case "4":
                    OvercastChoice = "Rainy";
                    break;
                default:
                    ChooseOvercast(rng);
                    break;

            }
            return OvercastChoice;
        }

        public void GetWeatherForcast(Random rng)
        {
            forcastOvercast = ChooseOvercast(rng);
            forcastTemperature = ChooseTemperature(rng, 50, 99);
            DisplayWeatherForcast();
            Console.ReadLine();
        }

        public void GetActualWeather(Random rng)
        {
            actualOvercast = forcastOvercast;
            actualTemperature = ChooseTemperature(rng, forcastTemperature -5, forcastTemperature + 6);
            DisplayActualWeather();
            Console.ReadLine();
            
        }

        public void DisplayWeatherForcast()
        {
            Console.WriteLine("Weather Forecast " + Environment.NewLine + "Temperature: " 
                + forcastTemperature + Environment.NewLine + "Overcast: " + forcastOvercast);
        }
        public void DisplayActualWeather()
        {
            Console.WriteLine("Current Weather " + Environment.NewLine + "Temperature: "
                + actualTemperature + Environment.NewLine + "Overcast: " + actualOvercast);
        }
    }
}
