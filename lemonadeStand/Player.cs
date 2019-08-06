namespace lemonadeStand
{
    abstract class Player
    {
        //member variables (Has A)
        public string name;
        public double Cash;
        public double newCash;
        Inventory inventory = new Inventory();

        //Constructor (Spawner)
        public Player()
        {
            this.Cash = 20.00;
            this.name = name;
            //inventory = 0;

        }


        //Member Methods (Can Do)
        

        public abstract int SetRecipe(int lemons, int sugar, int ice);

        public abstract void SetPrice();

    }

}
