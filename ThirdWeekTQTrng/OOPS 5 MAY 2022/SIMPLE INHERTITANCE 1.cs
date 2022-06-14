using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{ class Animal
    {
        public int legs = 4;
    }
    class Cat : Animal
    {
        public void show()
        {
            Console.WriteLine(legs);
        }
    }
    class SIMPLE_INHERTITANCE_1
    {
        static void Main(string[]args)
        {
            Cat c = new Cat();
            c.show();
        }
    }
}
