using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    static class UserInterface
    {
        //Member Variables (Has A)
        private static Random random = new Random();

        //Constructor (Spawner)
        

        //Member Methods (Can Do)
        public static int GetIntInput(string Prompt)
        {
            int result = 0;
            Console.WriteLine(Prompt);
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid");
                return GetIntInput(Prompt);
            }
            return result;
        }
      
        public static int GetIntInput(string Prompt1, string Prompt2)
        {
            int result = 0;
            Console.WriteLine($"{ Prompt1}{Prompt2}");
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid");
                return GetIntInput(Prompt1, Prompt2);
            }
            return result;
        }
        public static double GetDoubleInput(string prompt)
        {
            double result = 0.00;
            Console.WriteLine(prompt);
            try
            {
                result = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid");
                return GetIntInput(prompt);
            }
            return result;
        }
        public static int GetUserDays()
        {
            int userInput = GetIntInput("Please choose how many days you would like to play.");
            return userInput;
        }
        public static string GetUserReplay()
        {
            Console.WriteLine("Game Over. To play again type 'yes'"
                + Environment.NewLine + "to quit type 'quit'.");
            string UserInput = Console.ReadLine();
            return UserInput;
        }
        public static int GetUserIngredientLemons()
        {
            int LemonChoice = GetIntInput("Choose the ingredients you would like to use", "How many lemons would you like to use?");
            return LemonChoice;
        }
        public static int GetUserIngredientsSugar()
        {
            int SugarChoice = GetIntInput("How many cups of sugar would you like to use?");
            return SugarChoice;
        }
        public static int GetUserIngredientIce()
        {
            int IceChoice = GetIntInput("How many ice cubes per drink would you like to use?");
            return IceChoice;
        }
        public static double GetUserPrice()
        {

            double UserPrice = GetDoubleInput("How much would you like to charge per cup of lemonade?");
            return UserPrice;
        }
    }
}
