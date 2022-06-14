using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class Merge2ArraysUniqueWlements
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 4, 2, 4, 6, 8, 9, 3, 1, 5, 8 };
            int[] arr1 = { 10, 20, 40, 40, 50, 70, 90, 100 };
            
            Console.WriteLine("ARRAY1 ELEMENTS ARE AS:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("****************************************************");
            Console.WriteLine("ARRAY2 ELEMENTS ARE AS:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }



            int[] arr2 = new int[arr.Length + arr1.Length];
            int k=0;/*I NDEX OF arr2 stats from 0*/
            for(int i=0;i<arr.Length;i++)
            {
                bool isvisit = false;
                int count = 1;
                for(int j=i-1;j>=0;j--)
                {
                    if(arr[i]==arr[j])
                    {
                        isvisit = true;
                        break;
                    }
                }
                if(isvisit==false)
                {
                    for(int m=i+1;m<arr.Length;m++)
                    {
                        if(arr[i]==arr[m])
                        {
                            count++;
                        }
                    }
                    if(count==1)
                    {
                        arr2[k] = arr[i];
                        k++;
                    }
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                bool isvisit = false;
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr1[i] == arr1[j])
                    {
                        isvisit = true;
                        break;
                    }
                }
                if (isvisit == false)
                {
                    for (int m = i + 1; m < arr1.Length; m++)
                    {
                        if (arr1[i] == arr1[m])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        arr2[k] = arr1[i];
                        k++;
                    }
                }
            }
            Console.WriteLine("****************************************************");
            Console.WriteLine( "ELEMENTS OF MERGE ARRAY WITH UNIQUE MEMEBERS ONLY NOT CONTAIN REPEAT ELEMENTS");
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}

