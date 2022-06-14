using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._2_june_22_advanve_trng_day_1
{
    class exception_handling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("ENTER Your age");
            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("NAME IS  ="+name+"  AGE IS=  "+age);
                Console.WriteLine("Character at the 5th position in name is:=="+name[4]);
                Console.WriteLine("enter 2 numbers");
                int a = int.Parse(Console.ReadLine());
                int b= int.Parse(Console.ReadLine());
                Console.WriteLine("division  "+(a/b));
            }
            catch(FormatException e)//e is object
            {
                Console.WriteLine("AGE SHOULD BE NUMERIC");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
