using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game7Days
    {
        //member variables (Has A)
        public int NumberOfDays;
        public int Temperature;
        public string WeatherForcast;
        public double profits;
        protected Random rng;
        Store store = new Store();
        protected Player player = new Human();
        
        //Constructor (Spawner)

        public Game7Days()
        {
            this.Temperature = Temperature;
            rng = new Random();
            NumberOfDays = 7;
            this.store = store;
            

        }

        //Member Methods (Can Do)


        public void ReplayGame()
        {
            Console.WriteLine("Game Over. To play again with the same amount of days type 'yes'"
                + Environment.NewLine + "to quit type 'quit'.");
            string UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "yes":
                case "ya":
                case "yep":
                    UserInterface newGame = new UserInterface();
                    newGame.ChooseGameLength();
                    break;
                case "quit":
                    Console.WriteLine("Thanks for playing. Goodbye.");
                    break;
                default:
                    Console.WriteLine("Please choose an option from the list.");
                    break;
            }
        }

        public void ReportResults()
        {

        }

        public double TrackProfits()
        {

            return profits;
        }

        public void StartGame(List<Day>totalDays)
        {
            //setup
            foreach (Day el in totalDays)
            {


            }

        }

    }

}