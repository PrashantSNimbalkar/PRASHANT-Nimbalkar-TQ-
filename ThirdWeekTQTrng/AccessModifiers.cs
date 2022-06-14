using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class AccessModifiers
    {
        private int x = 10;
        protected int y = 20;
        public int z = 40;
        static void Main(string[]args)
        {
            AccessModifiers a = new AccessModifiers();
            Console.WriteLine(a.x);
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);
        }
    }
    class Info:AccessModifiers
    {
        void print()
        {
            AccessModifiers b = new AccessModifiers();
            /*Console.WriteLine(b.x);Cannot acces because private access modifier*/
            /*Console.WriteLine(b.y);Cannot acces because protected access modifier*/
            Console.WriteLine(b.z);
        }
    }
}
