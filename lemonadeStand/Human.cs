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
            expenses = 0.00;
           
            
        }

        //Member Methods (Can Do)
       public override int ChooseIngredientsLems()
        {
            Console.WriteLine("Choose the ingredients you would like to use");
            Console.WriteLine("How many lemons would you like to use?");
            int LemonChoice = int.Parse(Console.ReadLine());
            inventory.stockLemons -= LemonChoice;
            inventory.DisplayInventory(inventory.stockLemons, "lemons");
            return LemonChoice;
        }
        public override int ChooseIngredientsSug()
        {
            Console.WriteLine("How many cups of sugar would you like to use?");
            int SugarChoice = int.Parse(Console.ReadLine());
            inventory.stockSugar -= SugarChoice;
            inventory.DisplayInventory(inventory.stockSugar, "sugar");
            return SugarChoice;
        }

        public override int ChooseIngredientsIce()
        {
            Console.WriteLine("How many ice cubes per drink would you like to use?");
            int IceChoice = int.Parse(Console.ReadLine());
            inventory.stockIce -= IceChoice;
            inventory.DisplayInventory(inventory.stockIce, "ice cubes");
            return IceChoice;
        }

        public override void DisplayRecipe(int lemonsAmount, int sugarAmount, int iceAmount)
        {
         
            Console.WriteLine($"Your final recipe is {lemonsAmount} lemons, {sugarAmount} cups of sugar, and {iceAmount} cubes of ice per cup");
          
        }
        public override double SetPrice()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade?");
            double UserPrice = double.Parse(Console.ReadLine());
            return UserPrice;
           
        }
        public override double TrackExpenses(Store store)
        {
            expenses = store.cart;
            return expenses;
        }
        public override void DepsoitSales()
        {
            Cash += sales;
        }
    }
}
