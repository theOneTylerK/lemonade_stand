using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{

        abstract class Game
        {
            //member variables (Has A)
            public int NumberOfDays;
            public int Temperature;
            public string WeatherForcast;
            public double profits;
            private Random rng;
            //Constructor (Spawner)

            public Game()
            {
                this.Temperature = Temperature;
                rng = new Random();
            }

        //Member Methods (Can Do)


        public abstract void ReplayGame();


        public abstract void ReportResults();


        public abstract double TrackProfits();


        public abstract void StartGame();
            

        }

    
}
