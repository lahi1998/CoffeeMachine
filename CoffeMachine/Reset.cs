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

        public bool FILTERSTATUS
        {
            get { return FilterStatus; }
            set { FilterStatus = value; }
        }

        public int TEA
        {
            get { return Tea; }
            set { Tea = value; }
        }


        public Reset(int Water, int Coffee, int Tea, bool Filter, bool FilterStatus)
        {
            WATER = Water;
            COFFEE = Coffee;
            TEA = Tea;
            FILTER = Filter;
            FILTERSTATUS = FilterStatus;
        }

        public void RemoveWater()
        {
            Console.Clear();
            if (Water > 0)
            {
                Water = 0;
                Console.WriteLine("Emptied the water tank.");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("There no water in the tank.");
                Thread.Sleep(1500);
            }
        }


        public void RemoveFilter()
        {
            Console.Clear();
            if (Filter == true && Coffee != 0)
            {
                Filter = false;
                FilterStatus = false;
                Coffee = 0;
                Console.WriteLine("remove the filter with the coffee grounds.");
                Thread.Sleep(1500);
            }
            if (Filter == true && Tea != 0)
            {
                Filter = false;
                FilterStatus = false;
                Tea = 0;
                Console.WriteLine("remove the filter with the tea grounds.");
                Thread.Sleep(1500);
            }

        }
    }
}
