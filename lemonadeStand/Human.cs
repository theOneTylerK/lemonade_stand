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
            int LemonChoice = UserInterface.GetIntInput("Choose the ingredients you would like to use", "How many lemons would you like to use?");
            if(LemonChoice > inventory.stockLemons)
            {
                Console.WriteLine("You don't have enough lemons to do that");
                ChooseIngredientsLems();
            }
            else if(LemonChoice == 0)
            {
                Console.WriteLine("You can't make lemonade without lemons");
                ChooseIngredientsLems();
            }
            else
            {
                recipe.AddLemons(inventory, LemonChoice);

            }
           
            return LemonChoice;
        }
        public override int ChooseIngredientsSug()
        {
            int SugarChoice = UserInterface.GetIntInput("How many cups of sugar would you like to use per pitcher?");
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
                recipe.AddSugar(inventory, SugarChoice);
            }
            
            return SugarChoice;
        }

        public override int ChooseIngredientsIce()
        {
            int IceChoice = UserInterface.GetIntInput("Choose the ingredients you would like to use", "How many ice cubes would you like to use per cup?");
            if(IceChoice > inventory.stockIce)
            {
                Console.WriteLine("You don't have enough ice to do that");
                ChooseIngredientsIce();
            }
            else
            {

                recipe.AddIce(inventory, IceChoice);
            }
            return IceChoice;
        }

        public override void DisplayRecipe(int lemonsAmount, int sugarAmount, int iceAmount)
        {
           
                Console.WriteLine($"Your final recipe is {lemonsAmount} lemons, {sugarAmount} cups of sugar, and {iceAmount} cubes of ice per cup");
           
        }
        public override double SetPrice()
        {
            double UserPrice = UserInterface.GetDoubleInput("How much would you like to charge per cup of lemonade?");
            return UserPrice;
           
        }
        public override double TrackExpenses(Store store)
        {
            expenses = store.cart;
            return expenses;
        }
        public override void DisplayPlayerCash()
        {
            Console.WriteLine($"You have {Cash} dollars");
        }

    }
}
