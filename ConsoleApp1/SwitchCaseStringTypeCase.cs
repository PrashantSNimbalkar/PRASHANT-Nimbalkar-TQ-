using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchCaseStringTypeCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value Character :");
            string input = (Console.ReadLine());
            switch(input)
            {
                case "Happy":Console.WriteLine("Happy");
                    break;
                case "New":Console.WriteLine("New");
                    break;
                case "Year":Console.WriteLine("Year");
                    break;
                default:Console.WriteLine("WELCOME");
                    break;
            }
        }
    }
}

