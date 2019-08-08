﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CustomerSeniorCit :Customer
    {
        //member variables (Has A)
        
        //Constructor (Spawner)
        public CustomerSeniorCit()
        {
            this.spendingCash = 0.50;
            this.WillBuyChance = 50;
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
            if (day.weather.actualTemperature >= 70)
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 60;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    Console.WriteLine("All these dang kids and their fancy, new drinks. For the last time, NO!");
                    sellPrice = 0.00;
                    return sellPrice;
                }

            }
            if (day.weather.actualOvercast == "Sunny")
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 60;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    
                    return 0.00;
                }
            }
            else if (day.weather.actualOvercast == "Rainy")
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 30;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    Console.WriteLine("Yum");
                    return sellPrice;
                }
                else
                {
                    Console.WriteLine("All these dang kids and their fancy, new drinks. For the last time, NO!");
                    return 0.00;

                }
            }
            else
            {
                WillBuyChance = 50;
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
