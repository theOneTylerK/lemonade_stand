using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CustomerAdult : Customer
    {
        //member variables (Has A)

        //Constructor (Spawner)
        public CustomerAdult()
        {
            this.spendingCash = 1.00;
            this.WillBuyChance = 20;
        }

        //member methods (Can Do)
        public override double BuyLemonade(double lemonadePrice, Day day, Random rng)
        {
            if (lemonadePrice > spendingCash)
            {
                
                double sellprice = 0.00;
                Console.WriteLine("Too Expensive");
                return sellprice;
            }
            else
            {

                return DecideToPurchase(day, lemonadePrice, rng);
               
            }
        }

        public override double DecideToPurchase(Day day, double sellPrice, Random rng)
        {
            if (day.weather.actualTemperature >= 78)
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 40;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    Console.WriteLine("No Thanks");
                    return 0.00;
                }

            }
            if (day.weather.actualOvercast == "Sunny")
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 40;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    Console.WriteLine("Not Today, buddy");
                    return 0.00;
                }
            }
            else if (day.weather.actualOvercast == "Rainy")
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance =3;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    Console.WriteLine("No Thanks");
                    return 0.00;
                }
            }
            else
            {
                WillBuyChance = 20;
                int lowerThreshold = 0;
                int upperThreshold = 101;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    Console.WriteLine("Not Today, buddy");
                    return 0.00;
                }
                
            }
        }
    }
}
