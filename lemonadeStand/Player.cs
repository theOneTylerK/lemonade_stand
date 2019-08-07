namespace lemonadeStand
{
    abstract class Player
    {
        //member variables (Has A)
        public string name;
        public double Cash;
        public double expenses;
        public Inventory inventory = new Inventory();
        public double sales;


        //Constructor (Spawner)
        public Player()
        {
            this.Cash = 20.00;
            this.name = name;
            this.inventory = inventory;
            this.expenses = expenses;
            this.sales = 0.00;

        }


        //Member Methods (Can Do)
        public abstract int ChooseIngredientsLems();
        public abstract int ChooseIngredientsSug();
        public abstract int ChooseIngredientsIce();

        public abstract void DisplayRecipe(int lemons, int sugar, int ice);

        public abstract double SetPrice();
        public abstract double TrackExpenses(Store store);

        public abstract void DepsoitSales();

    }

}
