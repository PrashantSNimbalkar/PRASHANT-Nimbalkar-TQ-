using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_6_MAY_2022
{
    class GRANDSON
    {
        public int gsage = 12;
        public string gsname = "sumit";
        public void show()
        {
            Console.WriteLine(gsage + " " + gsname);
        }
    }
    class FATHER : GRANDSON
    {
        public int fage = 40;
        public void display()
        {
            Console.WriteLine(" " + fage);
        }
    }
    class GRANDFATHER : FATHER
    {
        public int gfage= 80;
        public void show1()
        {
            Console.WriteLine(" " + gfage);
        }
        public void ACCEPTDETAILS()
        {
            Console.WriteLine(gsage + " " + gsname + " " + fage + " " + gfage);
        }
    }
    class MULTILEVEL_IN_DEMO2
    {static void Main(string[] args)
        {
            GRANDFATHER m = new GRANDFATHER();
            m.show();
            m.show1();
            m.display();
            Console.WriteLine("////////////");
            m.ACCEPTDETAILS();
        }
    }
}
