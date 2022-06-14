using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{
    class BIKE
    {
        public int TYRE = 2;
    }
    class Pulsor : BIKE
    {
        public void show()
        {
            Console.WriteLine(TYRE);
        }
    }
    class SIDEMO_3
    {
        static void Main(string[] args)
        {
            Pulsor c = new Pulsor();
            c.show();
        }
    }
}
