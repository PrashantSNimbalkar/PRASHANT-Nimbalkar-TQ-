using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArmStrongNumberCheckWhileLoop
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, temp;
            Console.WriteLine("Enter The NUMBER:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {   r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("ARMSTRONG NUMBER");
            }
            else 
            { Console.WriteLine("NOT AARMSTRONG NUMBER"); }
        }
    }
}



