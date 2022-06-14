using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class MethodDemo
    {
        public void show_Data()
        {
            Console.WriteLine("HI I AM Show");
        }
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition=" + (a + b));
        }
        public string myFoo()
        {
            return "Hello";
        }
        public int add()
        {
            return 10 + 20;
        }
        public float areaOfCiricle(int r, float PI)
        {
            float area = PI * r * r;
            return area;
        }


        static void Main(string[] args)
        {
            MethodDemo m = new MethodDemo();
            m.show_Data();
            m.addition(7, 5);
            string str = m.myFoo();
            Console.WriteLine(str);
            /*Console.WriteLine(m.myFoo());*/
            int ans = m.add();
            Console.WriteLine(ans);
            float a = m.areaOfCiricle(4, 3.14f);
            Console.WriteLine("Area of Circle=" + a);
        }
    }
}

