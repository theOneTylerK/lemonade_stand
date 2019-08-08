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

        //Constructor (Spawner)
        

        //Member Methods (Can Do)

        public static int GetUserDays()
        {
            Console.WriteLine("Please choose how many days you would like to play.");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
    }
}
