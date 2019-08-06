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
        public int NumberOfDays;
        public int Temperature;
        public string WeatherForcast;
        public double profits;
        protected Random rng;
        Store store = new Store();
        protected Player player = new Human();
        protected List<Day> days = new List<Day>();
        public Weather weather = new Weather();
        
        
        //Constructor (Spawner)

        public Game()
        {
            this.Temperature = Temperature;
            rng = new Random();
            NumberOfDays = 7;
            this.store = store;
            
        }

        //Member Methods (Can Do)


        public  void ReplayGame()
        {
            Console.WriteLine("Game Over. To play again with the same amount of days type 'yes'"
                + Environment.NewLine + "to quit type 'quit'.");
            string UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "yes":
                case "ya":
                case "yep":
                    
                    break;
                case "quit":
                    Console.WriteLine("Thanks for playing. Goodbye.");
                    break;
                default:
                    Console.WriteLine("Please choose an option from the list.");
                    break;
            }
        }

        public  void ReportResults()
        {

        }

        public  double TrackProfits()
        {

            return profits;
        }

        public void GetDays()
        {
            Console.WriteLine("Please choose how many days you would like to play.");
            int userInput = int.Parse(Console.ReadLine());
            for (int i =0; i < userInput; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
       
        }

        public void StartGame()
        {
            GetDays();

            //setup

            foreach (Day day in days)
            {
                day.weather.GetWeatherForcast();
                store.SellItems(player);
                store.TakePayment(player);
                day.weather.GetActualWeather();
                Console.ReadLine();

            }

        }

    }

}