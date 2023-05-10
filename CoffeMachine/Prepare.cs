using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    // fyld vand

    // skift filter

    // tilføj kaffe
    internal class Prepare : CoffeeMachine
    {
        public int WATER
        {
            get { return Water; }
            set { Water = value; }
        }

        public int COFFEE
        {
            get { return Coffee; }
            set { Coffee = value; }
        }

        public bool FILTER
        {
            get { return Filter; }
            set { Filter = value; }
        }

        public Prepare(int Water, int Coffee, bool Filter) 
        {
            WATER = Water;
            COFFEE = Coffee;
            FILTER = Filter;

        }
       
        public void AddWater()
        {
            if (Water == 0) 
            {
                Water = 500;
                Console.WriteLine("Added {0}ml of water.", Water);
            }
            else
            {
                Console.WriteLine("There already water in the tank.");
            }
        }

        public void AddCoffee()
        {
            if (Coffee == 0)
            {
                Coffee = 250;
                Console.WriteLine("Added {0}g of Coffee.", Coffee);
            }
            else
            {
                Console.WriteLine("There already Coffee in the filter.");
            }
        }

        public void AddFilter() 
        {
            if (Filter == false)
            {
                Filter = true;
                Console.WriteLine("Added a filter.");
            }
            else
            {
                Console.WriteLine("Changed the filter.");
            }
        }

    }
}
