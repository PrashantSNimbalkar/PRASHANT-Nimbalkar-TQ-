using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Valid_String_Invalid_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING ONLY NUMBERS");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            int i;
            int sum1= 0;
            int sum2 = 0;
            for (i = 0; i < 3; i++)    //ADDITION OF 1ST 3 NUMBERS IN STRING
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    int x = int.Parse(str[i].ToString());  
                    sum1= sum1+ x;
                }
            }
            for (i =str.Length-1;i>str.Length-4;i--)//ADDITION OF LAST 3 DIGITS IN THE STRING
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    int y = int.Parse(str[i].ToString());
                    sum2 = sum2 + y;
                }
            }
            if(sum1==sum2)
            {
                Console.WriteLine("String Is Valid");
            }
            else
            {
                Console.WriteLine("String Is Not Valid");
            }


            Console.WriteLine(sum1);
            Console.WriteLine(sum2);



        }
    }
}
