using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_method_ovverriding
{
    class METHOD_OVERIDE_DEMO2
    {
        class Mobile                //parent class
        {
            public virtual void display()
            {
                Console.WriteLine("THIS IS A MOBILE  *************");
            }
        }
        class MOTO:Mobile //child class no 1
        {
            public override void display()
            {
                Console.WriteLine("THIS IS MOTO*************");
            }
        }
        class APPLE : Mobile //child class no 2
        {
            public override void display()
            {
                Console.WriteLine("THIS IS APPLE*************");
            }
        }
        static void Main(string[] args)
        {
            Mobile m1 = new MOTO();         // object created for parent class1 in method overriding
            m1.display();
            Console.WriteLine("*************************************");

            Mobile m2 = new APPLE();   // object created for parent class2 in method overriding
            m2.display();
            Console.WriteLine("*************************************");

            APPLE A = new APPLE();     //object created for child2 class saprow
            A.display();
            Console.WriteLine("*************************************");

            MOTO mot = new MOTO(); //object created for child1 class saprow
            mot.display();
            Console.WriteLine("*************************************");

            Mobile M = new Mobile();
            M.display();             //object created for parent class
            Console.WriteLine("*************************************");
        }
    }
}
