using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class ThreeCocepts1CLASS
    {
        public  ThreeCocepts1CLASS(): this(5) /*calling constructor through constructor*/
       { 
            Console.WriteLine("HII I AM A DEFAULT CONSTRUCTOR" ); 
       }
        public ThreeCocepts1CLASS (int b)
        {
            Console.WriteLine("HII  B---------"+b); 
        }
        void swapbyref(ref int x,ref int y)
        {
            Console.WriteLine("BEFORE SWAP IN SWAP METHOD==" + x+" " + y);
            int temp = x; ;
            x = y;
            y = temp;
            Console.WriteLine("After SWAP IN SWAP METHOD==" + x + " " + y);
            this.swapbyvalue(x,y);/*calling method through method*/
        }
        void swapbyvalue(int x,  int y)
        {
            Console.WriteLine("BEFORE SWAP IN SWAP METHOD==" + x + " " + y);
            int temp = x; ;
            x = y;
            y = temp;
            Console.WriteLine("After SWAP IN SWAP METHOD==" + x + " " + y);
        }
        static void Main(string[]args)
        {
            ThreeCocepts1CLASS a = new ThreeCocepts1CLASS();
            Console.WriteLine("ENTER NUM1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NUM2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            a.swapbyref(ref num1,ref num2);
            Console.WriteLine("After SWAP IN MAIN METHOD BY REFERNCE==" + num1+ " " +num2);
            Console.WriteLine("////////////////////////////////////////////////");
            a.swapbyvalue(num1,  num2);
            Console.WriteLine("After SWAP IN MAIN METHOD BY VALUE==" + num1 + " " + num2);
        }
    }
}

