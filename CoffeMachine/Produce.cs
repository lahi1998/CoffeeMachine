using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    internal class Produce : CoffeeMachine
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

        public Produce(int Water, int Coffee, bool Filter)
        {
            WATER = Water;
            COFFEE = Coffee;
            FILTER = Filter;

        }

        public void TurnOn()
        {
            Console.WriteLine("Coffee machine starts.");
            Console.WriteLine("Brrrrr brrr brr brr.");
            Thread.Sleep(20000);

            Water = 0;

            Console.WriteLine("Coffe pot is full.");
            Thread.Sleep(2000);
            TurnOf();
        }


        public void TurnOf()
        {
            if (Filter == true)
            {
                Filter = false;
                Coffee = 0;
                Console.WriteLine("Coffee machine stops.");
            }
            else
            {
                Console.WriteLine("Coffe pot was removed.");
                Console.WriteLine("Coffe pot was returned now empty.");
            }
        }
    }
}
