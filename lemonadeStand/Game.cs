using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game
    {
        //member variables (Has A)
        public double StartingCash;
        public int NumberOfDays;
        public int Temperature;
        public string WeatherForcast;
        public double profits;
        private Random rng;
        //Constructor (Spawner)

        public Game()
        {
            this.Temperature = Temperature;
            rng = new Random();
        }

        //Member Methods (Can Do)
        public void ChooseGameLength()
        {
            Console.WriteLine("Please Select the number of days you would like to play:"
                + Environment.NewLine + "For 7 Days, press 7");
            string LengthChoice = Console.ReadLine();
            switch (LengthChoice)
            {
                case "7":
                case "seven":
                    Console.WriteLine("Welcome to Lemonade Stand.");
                    break;
            }

        }

        public void ReplayGame()
        {

        }

        public void ReportResults()
        {

        }

        public double TrackProfits()
        {
            
            return profits;
        }

        public void StartGame()
        {
            ChooseGameLength();
            for (int i = 0; i < 7; i++)
            {
                Weather weather = new Weather(rng);

            }
            Console.ReadLine();
        }

    }
    
}
