using System;
using System.Collections.Generic;
using System.Text;

namespace MinValue
{
    class MinValue
    {        
        public static int minValue(int[] arr)
        {
            int minValue = arr[0];
            //Scan and find position that has min value
            for (int i = 0; i < arr.Length; i ++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            //Return min value
            return minValue;
        }

        public static void Main(string[] args)
        {   
            //Input size
            Console.Write("Enter a size: ");
                int size = Convert.ToInt32(Console.ReadLine());
            
            //Declare arr and input value to it
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("NO.{0}: ", (i+1));
                    arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Using minValue (function) to find min-value then print it to screen            
            Console.Write("The smallest element in the array is: {0}", minValue(arr));
        }
    }
}