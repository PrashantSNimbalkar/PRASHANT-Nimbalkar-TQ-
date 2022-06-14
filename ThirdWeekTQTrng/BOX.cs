using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class BOX
    {
        int height;
        int width;
        int length;
        int area; 
           static void Main(string[]args)
        {
            BOX box1 = new BOX();
            box1.height = 2;
            box1.width = 6;
            box1.length = 5;
            box1.area = ((2 * box1.length * box1.width) + (2 * box1.height * box1.width) + (2 *box1. height * box1.length));
            Console.WriteLine("Area Of Box1=" + box1.area);
            BOX box2 = new BOX();

        }
      
    }
}
