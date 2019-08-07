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
        public void ShowActualWeather()
        {
            weather.GetActualWeather();
        }

        public void ShowWeatherForcast()
        {
            weather.GetWeatherForcast();
        }

        public Customer GenerateCustomers(double lemonadePrice, Player player)
        {

            int PotentialCustomer = rng.Next(customers.Count);
            switch (PotentialCustomer)
            {
                case 0:
                    Console.WriteLine("Adult");
                    player.Cash += adult.BuyLemonade(lemonadePrice);
                    return adult;
                    break;
                case 1:
                    Console.WriteLine("Child");
                    player.Cash += child.BuyLemonade(lemonadePrice);
                    return child;
                    break;
                case 2:
                    Console.WriteLine("Senior");
                    player.Cash += senior.BuyLemonade(lemonadePrice);
                    return senior;
                    break;
                default:
                    Console.WriteLine("Adult");
                    player.Cash += adult.BuyLemonade(lemonadePrice);
                    return adult;
                    break;
                    
            }

        }
    }
}
