using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MenuSwitchCaseDoWhileLOOP
    {static void Main(string[] args)
        {char ch;
            do
            {
                int num1, num2;
                Console.WriteLine("Enter The Number 1 :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Number 2:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Ypur Choice");
                Console.WriteLine("1.ADDITION\n2.SUBTRACTION\n3.MULTIPLICATION\n4.DIVISION");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (1):
                        Console.WriteLine("ADDITION:" + (num1 + num2));
                        break;
                    case (2):
                        Console.WriteLine("SUBTRACTION:" + (num1 - num2));
                        break;
                    case (3):
                        Console.WriteLine("MULTIPLICATION:" + (num1 * num2));
                        break;
                    case (4):
                        Console.WriteLine("DIVISION:" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("WRONG CHOICE");
                        break;
                }
                Console.WriteLine("DO YOU WANT TO CONTINUE........");
                ch = Console.ReadLine()[0];
            }
                while (ch == 'y' || ch == 'Y');
        }
    }
}


