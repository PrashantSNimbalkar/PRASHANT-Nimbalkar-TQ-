using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class BIRD
    {
        public int WINGS = 2;
    }
    class SPARROW: BIRD
    {
        public void show()
        {
            Console.WriteLine(WINGS);
        }
    }
    class SIDEMO_4
    {
        static void Main(string[] args)
        {
            SPARROW c =new SPARROW();
            c.show();
        }
    }
}
