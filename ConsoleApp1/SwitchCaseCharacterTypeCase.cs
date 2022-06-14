using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchCaseCharacterTypeCase
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter The Number 1 :");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The CHARACTER :");
            op = Console.ReadLine()[0];
            switch(op)
            {
                case '+': Console.WriteLine("ADDITION:" + (num1 + num2));
                    break;
                case '-':Console.WriteLine("SUBTRACTION:" + (num1 - num2));
                    break;
                case '*': Console.WriteLine("MULTIPLICATION:" + (num1 * num2));
                    break;
                case '/':Console.WriteLine("DIVISION:" + (num1 / num2));
                    break;
                default:Console.WriteLine("WRONG DATA");
                    break;
            }
        }
    }
}

