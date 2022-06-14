using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TernaryOperatorDemoCompare2Numbers
    {
        static void Main(string[] args)
       {    int num1, num2;
            Console.WriteLine("Enter The Number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 > num2 ? num1 : num2;
            Console.WriteLine("Greater Number is :" + result);
        }
    }
}

