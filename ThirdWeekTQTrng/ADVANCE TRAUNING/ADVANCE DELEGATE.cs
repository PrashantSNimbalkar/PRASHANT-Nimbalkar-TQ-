using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdWeekTQTrng.ADVANCE_TRAUNING
{
    class ADVANCE_DELEGATE
    { static void Add(int a, int b)
        {
            Console.WriteLine("Sum is===" + (a + b));
        }
        static int Factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static bool IsEven(int p)
        {
            if (p % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Action<int, int> a1 = Add;
            a1(5, 7);


            Func<int, int> a2 = Factorial;
            int result = a2(5);
            Console.WriteLine("FACTORAILA OF NUM IS ==" + result);


            Predicate<int> a3 = IsEven;
            bool evencheckresult = a3(6);
            Console.WriteLine("Given number Is===" + evencheckresult);

        }
    }

    //2.CallBackFunctioon By Using Delegates And lambda,methods
    class Advdelegate2
    {
        static void Main(string[] args)
        {
            m3("KETKI", greet);
        }
        static void m3(string name, Action<string> functionpo)
        {
            Console.WriteLine("WELCOME");
            functionpo(name);
                
        }
        static void greet(string nm)
        {
            Console.WriteLine(nm+" WELCOME TO OUTER TUTORIAL");
        }



    }
}
