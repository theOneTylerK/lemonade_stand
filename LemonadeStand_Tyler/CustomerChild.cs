﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CustomerChild : Customer
    {
        //member variables (Has A)

        //Constructor (Spawner)
        public CustomerChild()
        {
            this.spendingCash = 0.30;
            this.WillBuyChance = 70;
        }

        //member methods (Can Do)
        public override double BuyLemonade(double lemonadePrice, Day day, Random rng, Player player)
        {
            if (lemonadePrice > spendingCash)
            {
                
                double sellprice = 0.00;
                Console.WriteLine("Too Expensive");
                return sellprice;
            }
           
            else
            {

                return DecideToPurchase(day, lemonadePrice, rng, player);
                
            }

        }
        public override double DecideToPurchase(Day day, double sellPrice, Random rng, Player player)
        {
            if (day.weather.actualTemperature >= 60)
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 80;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    if (player.inventory.stockCups <= 0 || player.inventory.stockIce <= 0)
                    {
                        Console.WriteLine("Sold Out");
                        return 0.00;
                    }
                    else
                    {
                        Console.WriteLine("Yum");
                        player.inventory.stockCups -= 1;
                        player.inventory.stockIce -= player.recipe.icePerCup;
                        return sellPrice;
                    } 
                    
                }
                else
                {
                    Console.WriteLine("None for me");
                    return 0.00;
                }
                
            }
            if (day.weather.actualOvercast == "Sunny")
            {
                int lowerThreshold = 0;
                int upperThreshold = 101;
                WillBuyChance = 80;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    if (player.inventory.stockCups <= 0 || player.inventory.stockIce <= 0)
                    {
                        Console.WriteLine("Sold Out");
                        return 0.00;
                    }
                    else
                    {
                        Console.WriteLine("Yum");
                        player.inventory.stockCups -= 1;
                        player.inventory.stockIce -= player.recipe.icePerCup;
                        return sellPrice;
                    }
                }
                else
                {
                    Console.WriteLine("No Thanks");
                    return 0.00;
                }
            }
            else
            {
                WillBuyChance = 70;
                int lowerThreshold = 0;
                int upperThreshold = 101;
                int purchaseChance = rng.Next(lowerThreshold, upperThreshold);
                if (purchaseChance <= WillBuyChance)
                {
                    if (player.inventory.stockCups <= 0 || player.inventory.stockIce <= 0)
                    {
                        Console.WriteLine("Sold Out");
                        return 0.00;
                    }
                    else
                    {
                        Console.WriteLine("Yum");
                        player.inventory.stockCups -= 1;
                        player.inventory.stockIce -= player.recipe.icePerCup;
                        return sellPrice;
                    }
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
