using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchCaseIntigerTypeCase
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number :");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case (1):Console.WriteLine("ONE");
                    break;
                case (2):Console.WriteLine("TWO");
                    break;
                case (3):Console.WriteLine("THREE");
                    break;
                case (4): Console.WriteLine("FOUR");
                    break;
                case (5):Console.WriteLine("FIVE");
                    break;
                default:Console.WriteLine("WRONG DATA");
                    break;
            }
        }
    }
}

