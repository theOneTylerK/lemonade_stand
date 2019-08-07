using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Human : Player
    {
        //member variables (Has A)
        

        //Constructor (Spawner)
        public Human()
        {
           
            
        }

        //Member Methods (Can Do)
       public override void ChooseIngredients()
        {
            Console.WriteLine("Choose the ingredients you would like to use");
            Console.WriteLine("How many lemons would you like to use?");
            int LemonChoice = int.Parse(Console.ReadLine());
            inventory.stockLemons -= LemonChoice;
            inventory.DisplayInventory(inventory.stockLemons, "lemons");
            Console.WriteLine("How many cups of sugar would you like to use?");
            int SugarChoice = int.Parse(Console.ReadLine());
            inventory.stockSugar -= SugarChoice;
            inventory.DisplayInventory(inventory.stockSugar, "sugar");
            Console.WriteLine("How many ice cubes per drink would you like to use?");
            int IceChoice = int.Parse(Console.ReadLine());
            inventory.stockIce -= IceChoice;
            inventory.DisplayInventory(inventory.stockIce, "lemons");


        }
        public override int SetRecipe(int lemons, int sugar, int ice)
        {
            int FinalRecipe = 1;
            return FinalRecipe;
          
        }
        public override void SetPrice()
        {
           
        }
    }
}
