using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    internal class Reset : CoffeeMachine
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

        public Reset(int Water, int Coffee, bool Filter)
        {
            WATER = Water;
            COFFEE = Coffee;
            FILTER = Filter;

        }

        public void RemoveWater()
        {
            if (Water > 0)
            {
                Water = 0;
                Console.WriteLine("Emptied the water tank.");
            }
            else
            {
                Console.WriteLine("There no water in the tank.");
            }
        }


        public void RemoveFilter()
        {
            if (Filter == true)
            {
                Filter = false;
                Coffee = 0;
                Console.WriteLine("remove the filter with the coffee grounds.");
            }
            else
            {
                Console.WriteLine("No filter to remove.");
            }
        }
    }
}
