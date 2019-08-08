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
                    StartGame();
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
            Console.WriteLine($"your total cash is now {player.Cash}");

        }

        public  void TrackDailyMoney()
        {
            double dailyExpenses = player.TrackExpenses(store);
            Console.WriteLine($"Your daily expenses were {dailyExpenses}");
            double dailyIncome = player.sales;
            Console.WriteLine($"Your daily income was {dailyIncome}");
            double endResult = dailyIncome - dailyExpenses;
            Console.WriteLine($"Your total daily profit is {endResult}");
            player.Cash += endResult;


        }

        public void GetDays()
        {
            int userInput = UserInterface.GetUserDays();
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
                player.DisplayRecipe(player.ChooseIngredientsLems(), player.ChooseIngredientsSug(), player.ChooseIngredientsIce());

                day.weather.GetActualWeather();
                var price = player.SetPrice();
                int index = 0;
            while(index < 100)
                {
                    day.GenerateCustomers(price, player, day);
                    index++;
                    if (index == 5)
                    {
                        break;
                    }
                }
                player.DepositSales();
                TrackDailyMoney();
                ReportResults();
                store.EmptyCart();
                Console.ReadLine();

            }
            ReplayGame();
        }

    }

}