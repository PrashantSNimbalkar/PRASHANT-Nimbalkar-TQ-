using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class StringMethodsDemo
    {
        static void Main(string[] args)
        {
            String str = "INDIA is My Country";
            int l = str.Length;       //Length is a method which counts characters and spaces also//
            Console.WriteLine("NO OF CHARACTRS IN STRING IS====="+l);
            Console.WriteLine("**************************************************");
            Console.WriteLine(str);
            Console.WriteLine("**************************************************");
            String str1 = str.Substring(6);//substring is a method which starts from
                                           //using no given by Length method
                              //substring here we stsrt from 6 so we got"is My Country" only
            Console.WriteLine("MY Substring is====="+str1);
            Console.WriteLine("**************************************************");
            string str2 = str.Substring(3, 8);//substring stsrs from 3rd character and end on eight number character
            Console.WriteLine("My another substring 2 is==="+str2);
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****************"+str.IndexOf('i'));
            Console.WriteLine("*****************" + str.IndexOf('I'));//IndexOf is a method which gives
                                                                      //index value of charcter in a string
            Console.WriteLine("*****************" + str.IndexOf('y'));
            
            Console.WriteLine("**************************************************");
            Console.WriteLine("*************"+str.LastIndexOf('y'));//LastIndexOf method gives index of character
            //which appears last time in the array. sometimes same character appear in array so to
            //to find out last appearnce index of that character we use this
            Console.WriteLine("**************************************************");
            string s1 = "INDIA IS BEST COUNTRY";
            string merge = str +" "+ s1;
            Console.WriteLine(merge);
            Console.WriteLine("**************************************************");
            string joinstr = string.Concat(str, ",",s1);
            Console.WriteLine("ConcatString Output Is========="+joinstr);
            Console.WriteLine("**************************************************");
            string s = "Hello";
            string SA1 = "hello";
            string SA2 = new string("Hello");

            Console.WriteLine(s==SA1);
            Console.WriteLine("**************************************************");
            Console.WriteLine(SA1==SA2);
            Console.WriteLine("**************************************************");
            Console.WriteLine(s.Equals(SA1));
            Console.WriteLine("**************************************************");
            Console.WriteLine(s.Equals(SA2));
            Console.WriteLine("**************************************************");


            Console.WriteLine(s.CompareTo(SA1));
            Console.WriteLine(s.CompareTo(SA2));
            Console.WriteLine(SA1.CompareTo(SA2));//INTERPOLLATION//
            Console.WriteLine("**************************************************");

            string msg = "Welcome to India";
            string mymsg = $"Hello{ msg}";
            Console.WriteLine(mymsg);
            Console.WriteLine("**************************************************");
            char[] ch = msg.ToCharArray();
            Console.WriteLine(String.Join(" ",ch));
            Console.WriteLine("**************************************************");
            Console.WriteLine(  "Upper Case  ="+msg.ToUpper());
            Console.WriteLine(msg);
            string mylower = "Hello.Net WORLD";
            string newlowercase = mylower.ToLower();
            Console.WriteLine(newlowercase);
            Console.WriteLine("**************************************************");
            
            String[] mywords = str.Split(" ");
            foreach(string st in mywords)
            {
                Console.WriteLine(st);
            }


        }

    }
}
