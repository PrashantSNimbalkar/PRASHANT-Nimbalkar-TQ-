using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_6_MAY_2022
{class Person
    {
        public int id = 78;
        public string pName = "SUMIT";
        public void show()
        {
            Console.WriteLine(id+" "+ pName);
        }
    }
    class Employee : Person
    {
        public int salary = 30000;
        public void display()
        {
            Console.WriteLine(" "+salary);
        }
    }
    class Manager : Employee
    {
        public int commition = 20000;
        public void show1()
        {
            Console.WriteLine( " " + commition);
        }
        public void ACCEPTDETAILS()
        {
            Console.WriteLine(id + " " + pName + " " + salary + " " + commition);
        }
    }

    class MULTILEVEL_IN_DEMO1
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.show();
            m.show1();
           m.display();
            Console.WriteLine("////////////");
            m.ACCEPTDETAILS();

        }
    }
}

