using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        // static void Max(int[] arr)
        // {
        //     int max = arr[0];
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         if(arr[i] > max)
        //         {
        //             max = arr[i];
        //         }
        //     }
        //     Console.WriteLine(max);
        // }

        // static void Avg(int[] arr)
        // {
        //     int count = 0;
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         count += arr[i];
        //     }
        //     Console.WriteLine(count/arr.Length);
        // }

        // static void GreaterThanY(int[] arr, int y)
        // {
        //     int count = 0;
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         if(arr[i] > y)
        //         {
        //             count++;
        //         }
        //     }
        //     Console.WriteLine(count);
        // }

        // static void SquareTheValues(int[] arr)
        // {
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         arr[i] = arr[i] * arr[i];
        //         Console.WriteLine(arr[i]);
        //     }
        // }

        // static int[] Negatives(int[] arr)
        // {
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         if(arr[i] < 0)
        //         {
        //             arr[i] = 0;
        //         }
        //         Console.WriteLine(arr[i]);
        //     }
        //      return arr;
        // }


        // static void OddArray()
        // {
        //     List<int> y = new List<int>();
        //     for(int i = 1; i < 256; i+=2)
        //     {
        //         y.Add(i);
        //     }

        //     y.ForEach(Console.Write);
        // }

        // static void Mma(int[] arr)
        // {
        //     int max = arr[0];
        //     int min = arr[0];
        //     int count = 0;
        //     for(int i = 0; i < arr.Length; i++)
        //     {
        //         if(arr[i] > max)
        //         {
        //             max = arr[i];
        //         }
        //         if(arr[i] < min)
        //         {
        //             min = arr[i];
        //         }
        //         count += arr[i];
        //     }
        //     Console.WriteLine(max);
        //     Console.WriteLine(min);
        //     Console.WriteLine(count/arr.Length);
        // }
        // static void Shift(List<int> y)
        // {
        //     y.RemoveAt(0);
        //     y.Add(0);
        //     y.ForEach(Console.WriteLine);
        // }

        static void Negatives(object[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if((int)arr[i] < 0)
                {
                    arr[i] = "Dojo";
                }
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // for (int i=1; i<256; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for (int i = 1; i < 256; i+=2)
            // {
            //     Console.WriteLine(i);
            // }


            // int count = 0;
            // for (int i = 0; i < 256; i++)
            // {
            //     count += i;
            //     Console.WriteLine("New Number: {0} Sum: {1}", i, count);
            // }

            // int[] array = {1,3,5,7,9,13};
            // for(int i=0; i < array.Length; i++)
            // {
            //     Console.Write(array[i]);
            // }

            // Max(new int[] {-3, -5, -7});
            // Avg(new int[] {3, 5, -2});
            // OddArray();
            // GreaterThanY(new int[] {1, 3, 5, 7}, 5);
            // SquareTheValues(new int[] {1, 5, 10, -2});
            // Negatives(new int[] {1, 5, 10, -2});
            // Mma(new int[] {1, 5, 10, -2});
            // Shift(new List<int>(){1, 5, 10, 7, -2});
            Negatives(new object[] {-1, -3, 2});
        }
    }
}
