using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
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

        private string? Cooked;

        public Produce(int Water, int Coffee, bool Filter)
        {
            WATER = Water;
            COFFEE = Coffee;
            FILTER = Filter;

        }

        public void TurnOn()
        {
            Console.Clear();
            Console.WriteLine("Machine starts.");
            Thread.Sleep(1500);
            Console.WriteLine("Brrrrr brrr brr brr.");
            Thread.Sleep(1500);

            Water = 0;

            if (Coffee > 0)
            {
                Cooked = "coffee";
            }

            Console.WriteLine("Cup is full of {0}", Cooked);
            TurnOf();
        }


        public void TurnOf()
        {
            Console.Clear();

            Console.WriteLine("Machine stops.");
            Thread.Sleep(1500);

            Console.WriteLine("Cup was removed.");
            Thread.Sleep(1500);
            Console.WriteLine("New Cup Added.");
            Thread.Sleep(1500);

        }
    }
}
