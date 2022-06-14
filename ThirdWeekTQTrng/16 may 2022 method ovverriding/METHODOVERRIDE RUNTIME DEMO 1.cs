using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_method_ovverriding
{
    class METHODOVERRIDE_RUNTIME_DEMO_1///MAIN CLASS
    {class Bird                  //parent class
        {
            public virtual void eat()
            {
                Console.WriteLine("bird is eating*************");
            }
        }
        class Sparrow:Bird //child class
        {
            public override void eat()
            {
                Console.WriteLine("Sparrow is Eating*************");
            }
        }
        static void Main(string[] args)
        {
            Sparrow sp = new Sparrow();        //object created for child class saprow
            sp.eat();
            Console.WriteLine("*****************************************************");
            Bird b = new Bird();     //object created for parent class
            b.eat();
            Console.WriteLine("*****************************************************");
            Bird s = new Sparrow();
            s.eat();              // object created for parent class in method overriding

        }
    }
}
