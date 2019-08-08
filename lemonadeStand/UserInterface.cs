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

        public static int GenerateRandomNumber(int min, int max)
        {
            random.Next(min, max);
            return 0;
        }
    }
}
