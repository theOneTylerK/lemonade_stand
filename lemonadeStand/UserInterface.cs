using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class UserInterface
    {
        //Member variables (has a)

        //Construtor (Spawner)
        public UserInterface()
        {

        }

        //Member Methods (Can Do)
        public void ChooseGameLength()
        {
            Console.WriteLine("Please Select the number of days you would like to play:"
                + Environment.NewLine + "For 7 Days, press 7");
            string LengthChoice = Console.ReadLine();
            switch (LengthChoice)
            {
                case "7":
                case "seven":
                    Game7Days game = new Game7Days();
                    game.StartGame();
                    break;
            }

        }
    }
}
