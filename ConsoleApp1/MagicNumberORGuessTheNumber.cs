using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MagicNumberORGuessTheNumber
    {
        static void Main(string[] args)
        {
            int magicnumber = 25;
            
            while (true)
            {
                Console.WriteLine("Enter The Number:");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num > magicnumber)
                {
                    Console.WriteLine("Number Is Greater Than MagicNumber pls Try Again:");
                }
                else if(num < magicnumber)
                {
                    Console.WriteLine("Number Is Smaller han MagicNumber pls Try Again:");
                }
                else
                {
                    Console.WriteLine("Number Is Equal TO MagicNumber:");
                }
            }
        }
    }
}
