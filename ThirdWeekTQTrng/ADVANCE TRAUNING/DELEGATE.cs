using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdWeekTQTrng.ADVANCE_TRAUNING
{
    //1. MULTICAST Deligate Programme
    public delegate void mydelegate(int x, int y);
    public delegate void mydel2(string n);
    internal class DELEGATE
    {
        static void add(int a, int b)

        {
            Console.WriteLine("sum=" + (a + b));
        }
        static void mult(int a, int b)

        {
            Console.WriteLine("product=" + (a * b));
        }
        void greet(string nm)
        {
            Console.WriteLine("WELCOME   " + nm);
        }
        static void Main(string[] args)
        {
            //callback
            //declare
            //Delegates====a variable which holds the refernce of a function
            //single cast deligates
            DELEGATE ob = new DELEGATE();
            mydel2 d2 = ob.greet;
            //multicast delegates
            mydelegate d1 = DELEGATE.mult;
            d1 += add;


            //d1.Invoke(10,20);
            //d2.Invoke("PRASHANT");
            d1(10, 20);
            d2("PRASHANT");
        }
    }






    //2.  SINGLE CAST DELEGATE PRIGRAMME
    public delegate void mydelegate1(int x, int y);
    public delegate void mydel02(string n);
    internal class DELEGATE1
    {
        static void add(int a, int b)

        {
            Console.WriteLine("sum=" + (a + b));
        }
        void greet(string nm)
        {
            Console.WriteLine("WELCOME   " + nm);
        }
        static void Main(string[] args)
        {
            DELEGATE1 OBJ = new DELEGATE1();
            mydelegate1 a1 = DELEGATE1.add;
            mydel02 a2 = OBJ.greet;
            a1(100, 200);
            a2("VARSH ");


        }
    }
   
    
    
    
    
    
    ////3.DIRECT DELEFATE USED AS FUNCTION OR METHOD ANNONYMOUS METHOD
    public delegate void mydelegate12(int x, int y);
    internal class xyz
    {
      /*  mydelegate12 d1 = delegate (int a, int b)//delegate used as finction or method//anonymous method
        {
            Console.WriteLine("ADDITION==" + (a + b));
        };
      */ //outside written of delegate is also allowed
        static void Main(string[] args)
        {
            mydelegate12 d1 = delegate (int a, int b)//delegate used as finction or method//anonymous method
              {
                  Console.WriteLine("ADDITION==" + (a + b));
              };


            d1(10, 20);
            
        }
    }

    ////4.lambda and delegate use
    ///lambda
    public delegate void mydelegate123(int a, int b);
    internal class xyz1
    {
        
        static void Main(string[] args)
        {
            mydelegate12 d1 = (x, y) =>
            {
                Console.WriteLine(x+y);
            };
            d1(10, 20);
            mydelegate123 d2 = (x, y) => Console.WriteLine(x+y);
            d2(10, 20);
        }
    }


}


