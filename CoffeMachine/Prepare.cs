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
            Console.Clear();
            if (Water == 0) 
            {
                Water = 500;
                Console.WriteLine("Added {0}ml of water.", Water);
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("There already water in the tank.");
                Thread.Sleep(1500);
            }
        }

        public void AddCoffee()
        {
            Console.Clear();
            if (Coffee == 0)
            {
                Coffee = 250;
                Console.WriteLine("Added {0}g of Coffee.", Coffee);
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("There already Coffee in the filter.");
                Thread.Sleep(1500);
            }
        }

        public void AddFilter() 
        {
            Console.Clear();
            if (Filter == false)
            {
                Filter = true;
                Console.WriteLine("Added a filter.");
                Thread.Sleep(1500);
            }
        }

    }
}
