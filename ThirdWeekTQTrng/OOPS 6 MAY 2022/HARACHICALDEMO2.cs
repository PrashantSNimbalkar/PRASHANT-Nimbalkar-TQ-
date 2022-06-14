using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_6_MAY_2022
{
    class Country
    {
        public string cname = "COUNTRY NAME";
        void mycountry()
        {
            Console.WriteLine(cname);
        }
    }
    class India : Country
    {
        public void show()
        {
            cname = "INDIA";
            Console.WriteLine("COUNTRY NAME IS =="+cname);
        }
    }
    class England : Country
    {
        public void display()
        {
            cname = "England";
            Console.WriteLine("COUNTRY NAME IS ==" + cname);
        }
    }
    class Nepal : Country
    {
        public void view()
        {
            cname = "NEPAL";
            Console.WriteLine("COUNTRY NAME IS ==" + cname);
        }
    }
    class HARACHICALDEMO2
    {
        static void Main(string[]args)
        {
            India i = new India();
            i.show();
            England e = new England();
            e.display();
            Nepal n = new Nepal();
            n.view();
            Console.WriteLine(i.cname);
            Console.WriteLine(e.cname);
            Console.WriteLine(n.cname);
        }
              
    }
} 
