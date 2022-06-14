using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class PASSBYVALUE
    {
        void swapbyref(ref int x, ref int y)
        {
            Console.WriteLine("BEFORE SWAP IN SWAP METHOD==" + x + " " + y);
            int temp = x; ;
            x = y;
            y = temp;
            Console.WriteLine("After SWAP IN SWAP METHOD==" + x + " " + y);    
        }
        void swapbyvalue(int x, int y)
        {
            Console.WriteLine("BEFORE SWAP IN SWAP METHOD==" + x + " " + y);
            int temp = x; ;
            x = y;
            y = temp;
            Console.WriteLine("After SWAP IN SWAP METHOD==" + x + " " + y);
        }
        static void Main(string[] args)
        {
            PASSBYVALUE a = new PASSBYVALUE();
            Console.WriteLine("ENTER NUM1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NUM2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            a.swapbyref(ref num1, ref num2);
            Console.WriteLine("After SWAP IN MAIN METHOD BY REFERNCE==" + num1 + " " + num2);
            Console.WriteLine("////////////////////////////////////////////////");
            a.swapbyvalue(num1, num2);
            Console.WriteLine("After SWAP IN MAIN METHOD BY VALUE==" + num1 + " " + num2);
        }
    }
}
