﻿using System;
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
            string UserInput = UserInterface.GetUserReplay();
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
            Console.WriteLine($"your total cash is now ${player.Cash}");

        }

        public  void TrackDailyMoney()
        {
            double dailyExpenses = Math.Round(player.TrackExpenses(store));
            Console.WriteLine($"Your daily expenses were ${dailyExpenses}");
            double dailyIncome = player.sales;
            Console.WriteLine($"Your daily income was ${dailyIncome}");
            double endResult = dailyIncome - dailyExpenses;
            Console.WriteLine($"Your total daily profit is ${endResult}");
            player.Cash += endResult;
        }

        public void GetDays()
        {
            int userInput = UserInterface.GetIntInput("Please choose how many days you would like to play.");
            for (int i =0; i < userInput; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
       
        }
        public void EndGame()
        {
            double StartMoney = 20.00;
            double CashMoney = player.Cash - StartMoney;
            if(CashMoney < StartMoney)
            {
                Console.WriteLine($"Too bad. You took a loss. You started with ${StartMoney}. You finished with ${player.Cash}. You venture cost you ${CashMoney}");
                ReplayGame();
            }
            else
            {
                Console.WriteLine($"Congratulations. You started with ${StartMoney}. You finished with ${player.Cash}. You venture made ${CashMoney}");
                ReplayGame();
            }
            
        }

        public void StartGame()
        {
            GetDays();

            player.inventory.stockSugar = 0;
            player.inventory.stockLemons = 0;
            player.inventory.stockIce = 0;
            player.inventory.stockCups = 0;
            player.Cash = 20.00;

            foreach (Day day in days)
            {
                if (player.Cash < 0.49 || (player.inventory.stockLemons >= 1 && player.inventory.stockSugar >= 1))
                {
                    Console.WriteLine("You can't afford to buy enough supplies to make more lemonade.");
                    break;
                }
                day.weather.GetWeatherForcast(rng);
                player.DisplayPlayerCash();
                store.SellItems(player);
                player.DisplayRecipe(player.ChooseIngredientsLems(), player.ChooseIngredientsSug(), player.ChooseIngredientsIce());
                day.weather.GetActualWeather(rng);
                var price = player.SetPrice();
                int index = 0;
                while(index < 100)
                {
                    day.GenerateCustomers(price, player, day, rng);
                    index++;
                    if (index == 100)
                    {
                        break;
                    }
                   
                }
               
                TrackDailyMoney();
                ReportResults();
                store.EmptyCart();
                if (player.Cash <= 0)
                {
                    Console.WriteLine("Game Over. You ran out of money.");
                    Console.ReadLine();
                    break;
                }

            }
            EndGame();
        }

    }

}