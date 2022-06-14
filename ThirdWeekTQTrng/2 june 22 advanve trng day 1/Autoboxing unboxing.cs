using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._2_june_22_advanve_trng_day_1
{
    class Autoboxing_unboxing
    {
        static void Main(string[] args)
        {
            int a = 10;
            object ob = a;//autoboxing
            int d = (int)ob;//unboxing
            Console.WriteLine(a);//10
            Console.WriteLine(d);//10
            Console.WriteLine(ob);//10
        }
    }
}
