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
        Random rng = new Random();
        List<string> overcast = new List<string>();


        //Constructor (Spawner)
        public Weather()
        {
            overcast.Add("Sunny");
            overcast.Add("Partly Sunny");
            overcast.Add("Cloudy");
            overcast.Add("Partly Cloudy");
            overcast.Add("Rainy");
            this.Temperature = Temperature;
        }
        
        


        //member methods (Can Do)
        public int ChooseTemperature(int min, int max)
        {

            int CurrentTemp = rng.Next(min, max);
            return CurrentTemp;

        }

        public string ChooseOvercast()
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
                    ChooseOvercast();
                    break;

            }
            return OvercastChoice;
        }

        public void GetWeatherReport()
        {
            string Overcast = ChooseOvercast();
            int Temp = ChooseTemperature(50, 99);
            Console.WriteLine("Temperature: " + Temp + Environment.NewLine + "Overcast: " + Overcast);
        }
    }
}
