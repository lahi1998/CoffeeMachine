using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    internal class Display
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("#########################");
            Console.WriteLine("1 : Add water");
            Console.WriteLine("2 : Remove water");
            Console.WriteLine("3 : Add filter");
            Console.WriteLine("4 : Remove filter");
            Console.WriteLine("5 : Add coffee");
            Console.WriteLine("6 : Add tea");
            Console.WriteLine("7 : Add espresso");
            Console.WriteLine("8 : Turn On");
        }
    }
}
