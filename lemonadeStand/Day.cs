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
        Customer adult = new CustomerAdult();
        Customer child = new CustomerChild();
        Customer senior = new CustomerSeniorCit();
        List<Customer> customers = new List<Customer>();



        //Constructor (Spawner)
        public Day()
        {
            customers.Add(adult);
            customers.Add(child);
            customers.Add(senior);

        }

        //member methods (Can Do)
        public void ShowActualWeather(Random rng)
        {
            weather.GetActualWeather(rng);
        }

        public void ShowWeatherForcast(Random rng)
        {
            weather.GetWeatherForcast(rng);
        }

        public Customer GenerateCustomers(double lemonadePrice, Player player, Day day)
        {
            int x = UserInterface.GenerateRandomNumber(0, customers.Count);
            int PotentialCustomer = rng.Next(customers.Count);
            switch (PotentialCustomer)
            {
                case 0:
                    Console.WriteLine("Adult");
                    player.sales += adult.BuyLemonade(lemonadePrice, day);
                    return adult;
                    break;
                case 1:
                    Console.WriteLine("Child");
                    player.sales += child.BuyLemonade(lemonadePrice, day);
                    return child;
                    break;
                case 2:
                    Console.WriteLine("Senior");
                    player.sales += senior.BuyLemonade(lemonadePrice, day);
                    return senior;
                    break;
                default:
                    Console.WriteLine("Adult");
                    player.sales += adult.BuyLemonade(lemonadePrice, day);
                    return adult;
                    break;
                    
            }

        }
    }
}
