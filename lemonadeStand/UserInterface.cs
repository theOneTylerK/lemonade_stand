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

        public static int GetUserDays()
        {
            Console.WriteLine("Please choose how many days you would like to play.");
            int userInput = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Choose the ingredients you would like to use");
            Console.WriteLine("How many lemons would you like to use?");
            int LemonChoice = int.Parse(Console.ReadLine());
            return LemonChoice;
        }
        public static int GetUserIngredientsSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to use?");
            int SugarChoice = int.Parse(Console.ReadLine());
            return SugarChoice;
        }
        public static int GetUserIngredientIce()
        {
            Console.WriteLine("How many ice cubes per drink would you like to use?");
            int IceChoice = int.Parse(Console.ReadLine());
            return IceChoice;
        }
        public static double GetUserPrice()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade?");
            double UserPrice = double.Parse(Console.ReadLine());
            return UserPrice;
        }
    }
}
