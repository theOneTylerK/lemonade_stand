using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Inventory
    {
        //member variables (Has A)
        public int stockLemons;
        public int stockSugar;
        public int stockCups;
        public int stockIce;


        //Constructor (Spawner)
        public Inventory()
        {
            stockLemons = 0;
            stockSugar = 0;
            stockCups = 0;
            stockIce = 0;
        }

        //member methods (Can Do)
        public int AddLemons()
        {
            return stockLemons;
        }
        public int AddSugar()
        {
            return stockSugar;
        }
        public int AddCups()
        {
            return stockCups;
        }
        public int AddIce()
        {
            return stockIce;
        }
    }
}
