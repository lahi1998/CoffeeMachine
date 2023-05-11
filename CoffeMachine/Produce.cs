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

        public int TEA
        {
            get { return Tea; }
            set { Tea = value; }
        }

        public int ESPRESSO
        {
            get { return Espresso; }
            set { Espresso = value; }
        }

        private string? Cooked;


        public Produce(int Water, int Coffee, int Tea, int Espresso, bool Filter)
        {
            WATER = Water;
            COFFEE = Coffee;
            TEA = Tea;
            FILTER = Filter;
            ESPRESSO = Espresso;
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
            if ( Tea > 0)
            {
                Cooked = "tea";

            }
            if (Espresso > 0)
            {
                Cooked = "espresso";
            }

            Console.WriteLine("Cup is full of {0}", Cooked);
            Thread.Sleep(1500);
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
