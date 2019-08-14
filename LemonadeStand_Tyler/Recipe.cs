using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Recipe
    {
        public int icePerCup;
        public Recipe()
        {

        }

        public int AddLemons(Inventory inventory, int LemonChoice)
        {
            inventory.stockLemons -= LemonChoice;
            inventory.DisplayInventory(inventory.stockLemons, "lemons");
            return LemonChoice;
        }
        public int AddSugar(Inventory inventory, int SugarChoice)
        {
            inventory.stockSugar -= SugarChoice;
            inventory.DisplayInventory(inventory.stockSugar, "sugar");
            return SugarChoice;
        }
        public int AddIce(Inventory inventory, int IceChoice)
        {
            inventory.stockIce -= IceChoice;
            inventory.DisplayInventory(inventory.stockIce, "ice cubes");
            icePerCup = IceChoice;
            return IceChoice;
        }

    }
}
