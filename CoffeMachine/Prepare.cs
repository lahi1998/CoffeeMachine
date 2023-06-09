﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{

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
        public int ESPRESSO
        {
            get { return Espresso; }
            set { Espresso = value; }
        }

        public Prepare(int Water, int Coffee, int Tea, int Espresso, bool Filter, bool FilterStatus) 
        {
            WATER = Water;
            COFFEE = Coffee;
            TEA = Tea;
            ESPRESSO = Espresso;
            FILTER = Filter;
            FILTERSTATUS = FilterStatus;
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
            if (Coffee == 0 && FilterStatus == false)
            {
                Coffee = 250;
                FilterStatus = true;
                Console.WriteLine("Added {0}g of Coffee.", Coffee);
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("There already something in the filter.");
                Thread.Sleep(1500);
            }
        }

        public void AddTea()
        {
            Console.Clear();
            if (Tea == 0 && FilterStatus == false)
            {
                Tea = 250;
                FilterStatus = true;
                Console.WriteLine("Added {0}g of tea.", Tea);
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("There already something in the filter.");
                Thread.Sleep(1500);
            }
        }

        public void AddEspresso()
        {
            Console.Clear();
            if (Espresso == 0 && FilterStatus == false)
            {
                Espresso = 25;
                FilterStatus = true;
                Console.WriteLine("Added {0}g of espresso.", Espresso);
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("There already something in the filter.");
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
            else
            {
                Console.WriteLine("Already a filter in the machine");
                Thread.Sleep(1500);
            }
        }

    }
}
