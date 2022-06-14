using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SumOfPrimeNumbersIN_1_To_N
    {
        static void Main(string[] args)
        {
            int i, j, Count, sum = 0, num;
            Console.WriteLine("Enter The NUMBER UPTO WHICH You Have Sum Of Prime Numbers From 1 To N:");
            num = Convert.ToInt32(Console.ReadLine());
            for ( i =1; i <= num; i++)
            {
                Count = 0;
                for(j=2;j<=(i/2);j++)
                {
                    if(i%j==0)
                    { Count++; }
                }
                if(Count==0 &&  i!=1)
                {
                   sum = sum + i;
                }
            }
            Console.WriteLine(" The Sum Of Prime Numbers From 1 To " +num+ " IS:"+sum);

        }
    }
}
