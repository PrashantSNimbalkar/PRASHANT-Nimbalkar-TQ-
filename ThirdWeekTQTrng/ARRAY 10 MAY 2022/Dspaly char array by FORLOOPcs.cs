using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class Dspaly_char_array_by_FORLOOPcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE SIZE OF ARRAY");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] character = new char[size];
            Console.WriteLine("ENTER THE ELEMENTS OF ARRAY");
            for (int i = 0; i <character.Length; i++)
            {
                char x = Console.ReadLine()[0];
                character[i] = x;
            }
            Console.WriteLine("************+++++***********");
            for (int i = 0; i <character.Length; i++)
            {
                Console.WriteLine(character[i]);
            }
        }
    }
}
