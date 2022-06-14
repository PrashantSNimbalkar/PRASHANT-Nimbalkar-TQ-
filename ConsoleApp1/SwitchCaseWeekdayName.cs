using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchCaseWeekdayName
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number of Day You Want To Print:");
            num= Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case (1): Console.WriteLine("MONDAY");
                    break;
                case (2):Console.WriteLine("TUESDAY");
                    break;
                case (3): Console.WriteLine("WEDNESDAY");
                    break;
                case (4):Console.WriteLine("THURSDAY");
                    break;
                case (5):Console.WriteLine("FRIDAY");
                    break;
                case (6): Console.WriteLine("SATURDAY");
                    break;
                case (7):Console.WriteLine("SUNDAY");
                    break;
                default:Console.WriteLine("WRONG DATA");
                    break;
            }
        }
    }
}

