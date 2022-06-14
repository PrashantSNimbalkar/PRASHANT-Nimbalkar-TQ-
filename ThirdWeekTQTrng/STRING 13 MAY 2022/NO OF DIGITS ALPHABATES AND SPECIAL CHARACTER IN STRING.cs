using System;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class NO_OF_DIGITS_ALPHABATES_AND_SPECIAL_CHARACTER_IN_STRING
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            int count = 0;
            int alpha = 0;
            int symbol = 0;
            int i;
            for (i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))  //if((str[i]>='a' && (str[i]<='z'))||(str[i]>='A'&&str[i]>='Z'))//
                {
                    alpha++;
                }
                else if (Char.IsDigit(str[i]))  //if(str[i]>='0'&& str[i]<='9')//
                {
                    count++;
                }
                else
                {
                    symbol++;
                }
            }
            Console.WriteLine("NUNBER OF DIGITS IN STRING===" + count);
            Console.WriteLine("NUNBER OF ALPHABATES IN STRING===" + alpha);
            Console.WriteLine("NUNBER OF SYMBOLS IN STRING===" + symbol);
        }
    }
}
