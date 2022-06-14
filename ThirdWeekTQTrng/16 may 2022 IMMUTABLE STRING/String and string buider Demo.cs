using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_IMMUTABLE_STRING
{
    class String_and_string_buider_Demo
    {
        static void Main(string[] args)
        {
            String s = "HELLO";///string
            s = s + "PUNE";///immutable string
           
            
            
            StringBuilder sb = new StringBuilder("Hello");///stringbuider declration
            sb.Append("Pune");//joined"Pune"in stringbuilder sb  Append is inbuild method
            Console.WriteLine(sb);//display sb
            

            sb.Insert(5, "C#");//  insert C# in sb after 5 characters in sb sb=Helloc#// Insert Is INbuilt Function
            Console.WriteLine(sb);
            sb.Replace("Pune", "PROGRAMME");//Repalce Pune with Programme in Stringbuildeer sb Replace is function
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder();//declared and assign stringbuilder with append only
            sb1.Append("PRASHANT");
            sb1.Append(" Great");
            Console.WriteLine(sb1);
            Console.WriteLine("**************************");
            Console.WriteLine(sb + " " + sb1);

            StringBuilder sb3 = new StringBuilder("India", 60);// 60 is int capacity of stringbuider


            for(int i=0;i<sb3.Length;i++)///display for loop to display sb3  display sb3=inda times of length of sb3 5 times
            {
                Console.WriteLine(sb3);
            }
            Console.WriteLine("**************************");
            
            Console.WriteLine(sb.Equals(sb1));//checking both string are eueal or not in true or false
            Console.WriteLine(sb==sb1);//checking both string are eueal or not in true or false


            string str = sb.ToString();//convert strinbuilder sb into string str
            string str1 = sb1.ToString();//convert strinbuilder sb1 into string str1
            Console.WriteLine(str.CompareTo(str1));//compare string str and str1
           
            Console.WriteLine(str);
            Console.WriteLine(str1);






        }

    }
}
