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
        List<Day> totalDays = new List<Day>();
        Day el = new Day();
        Game7Days game = new Game7Days();
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
                    totalDays.Add(el);
                    totalDays.Add(el);
                    totalDays.Add(el);
                    totalDays.Add(el);
                    totalDays.Add(el);
                    totalDays.Add(el);
                    totalDays.Add(el);                  
                    game.StartGame(totalDays);
                    break;
            }

        }
    }
}
