using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class FrequencyOfElementsArray
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 4, 6, 7, 6, 6, 2, 1, 4 };
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                Boolean isvisit = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisit = true;
                        break;
                    }
                }
                if (isvisit == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    
                 Console.WriteLine(a[i] + "  " + count);
                   
                }
            }
        }
    }
}
