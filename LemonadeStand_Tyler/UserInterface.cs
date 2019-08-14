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
            Console.WriteLine($"{ Prompt1}" + Environment.NewLine + $"{Prompt2}");
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
       
        public static string GetUserReplay()
        {
            Console.WriteLine("To play again type 'yes'"
                + Environment.NewLine + "to quit type 'quit'.");
            string UserInput = Console.ReadLine();
            return UserInput;
        }
       
    }
}
