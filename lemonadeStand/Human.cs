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
            int LemonChoice = UserInterface.GetUserIngredientLemons();
            inventory.stockLemons -= LemonChoice;
            inventory.DisplayInventory(inventory.stockLemons, "lemons");
            return LemonChoice;
        }
        public override int ChooseIngredientsSug()
        {
            int SugarChoice = UserInterface.GetUserIngredientsSugar();
            inventory.stockSugar -= SugarChoice;
            inventory.DisplayInventory(inventory.stockSugar, "sugar");
            return SugarChoice;
        }

        public override int ChooseIngredientsIce()
        {
            int IceChoice = UserInterface.GetUserIngredientIce();
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
            double UserPrice = UserInterface.GetUserPrice();
            return UserPrice;
           
        }
        public override double TrackExpenses(Store store)
        {
            expenses = store.cart;
            return expenses;
        }
        
    }
}
