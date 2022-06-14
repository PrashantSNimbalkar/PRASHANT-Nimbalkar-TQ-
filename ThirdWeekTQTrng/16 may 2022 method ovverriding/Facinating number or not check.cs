using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_method_ovverriding
{
    class Facinating_number_or_not_check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUM TO CHECK FASCINATING NUM 0R NOT");
            String num = Console.ReadLine();
            int number;
            string newNUM = " ";
            for (int i = 0; i < num.Length; i++)
            {
                int x = int.Parse(num[i].ToString());
                number = x;
                for(int j=1;j<=3;j++)
                {
                    newNUM = newNUM + (number * j);
                }

            }
            Console.WriteLine(num);
            Console.WriteLine(newNUM);
            Console.WriteLine("******************************");
            string[] FNUM  = newNUM.Split(" ");
            for (int i = 0; i < FNUM.Length; i++)
            {
                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (FNUM[i] == FNUM[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                for (int j = i + 1; j < FNUM.Length; j++)
                {
                    if (FNUM[i] == FNUM[j])
                    {
                        count++;
                    }
                }
                if (count == 1)   //unique elements condition main case
                {
                    Console.WriteLine("NUMBER ENTER BY YOU IS FASCINATING NUMBER");
                }
                else
                {
                    Console.WriteLine("NUMBER ENTER BY YOU IS NOT FASCINATING NUMBER");
                }

            }

        }
    }
}
