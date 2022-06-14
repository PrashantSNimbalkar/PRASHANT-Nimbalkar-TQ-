using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchCaseVowelConsonents
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter The CHARACTER:");
            ch = Console.ReadLine()[0];
            switch(ch)
            {
                case('a'):Console.WriteLine("VOWEL");
                    break;
                case ('e'):Console.WriteLine("VOWEL");
                    break;
                case ('i'):Console.WriteLine("VOWEL");
                    break;
                case ('o'): Console.WriteLine("VOWEL");
                    break;
                case ('u'):Console.WriteLine("VOWEL");
                    break;
                case ('A'):Console.WriteLine("VOWEL");
                    break;
                case ('E'):Console.WriteLine("VOWEL");
                    break;
                case ('I'):Console.WriteLine("VOWEL");
                    break;
                case ('O'):Console.WriteLine("VOWEL");
                    break;
                case ('U'):Console.WriteLine("VOWEL");
                    break;
                default:Console.WriteLine("CONSONENT");
                    break;
            }
        }

    }
}

