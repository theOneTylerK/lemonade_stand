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
            if(LemonChoice > inventory.stockLemons)
            {
                Console.WriteLine("You don't have enough lemons to do that");
                ChooseIngredientsLems();
            }
            else if(LemonChoice == 0)
            {
                Console.WriteLine("You can't make lemonade without lemons");
                ChooseIngredientsSug();
            }
            else
            {
                inventory.stockLemons -= LemonChoice;
                inventory.DisplayInventory(inventory.stockLemons, "lemons");
            }
           
            return LemonChoice;
        }
        public override int ChooseIngredientsSug()
        {
            int SugarChoice = UserInterface.GetUserIngredientsSugar();
            if(SugarChoice > inventory.stockSugar)
            {
                Console.WriteLine("You don't have enough sugar to do that");
                ChooseIngredientsSug();
            }
            else if(SugarChoice == 0)
            {
                Console.WriteLine("You need sugar to make lemonade");
                ChooseIngredientsSug();
            }
            else
            {
                inventory.stockSugar -= SugarChoice;
                inventory.DisplayInventory(inventory.stockSugar, "sugar");
            }
            
            return SugarChoice;
        }

        public override int ChooseIngredientsIce()
        {
            int IceChoice = UserInterface.GetUserIngredientIce();
            if(IceChoice > inventory.stockIce)
            {
                Console.WriteLine("You don't have enough ice to do that");
                ChooseIngredientsIce();
            }
            else
            {
                inventory.stockIce -= IceChoice;
                inventory.DisplayInventory(inventory.stockIce, "ice cubes");
            }
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
