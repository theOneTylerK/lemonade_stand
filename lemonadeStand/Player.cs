namespace lemonadeStand
{
    abstract class Player
    {
        //member variables (Has A)
        public string name;
        public double Cash;
        public Inventory inventory = new Inventory();
        

        //Constructor (Spawner)
        public Player()
        {
            this.Cash = 20.00;
            this.name = name;
            this.inventory = inventory;

        }


        //Member Methods (Can Do)
        public abstract int ChooseIngredientsLems();
        public abstract int ChooseIngredientsSug();
        public abstract int ChooseIngredientsIce();

        public abstract void DisplayRecipe(int lemons, int sugar, int ice);

        public abstract double SetPrice();

    }

}
