using System;
using System.Collections.Generic;
using System.Text;

namespace DelValueUsingMethod
{
    class DelValueUsingMethod
    {        
        public static void delValueFromArray(ref int[] arr, int delValue)
        {
            int minValue = arr[0];
            int index_del = -6;
            bool existedDelValue = false;
            //Scan and find position that has min value
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == delValue)
                {
                    index_del = i;                    
                    existedDelValue = true;
                }
            }

            //Check if value need-to-be deleted exist or not
            if (existedDelValue)                        
            {
                //Deleting process
                for (int j = index_del; j < arr.Length; j++)
                {
                    if (j != (arr.Length - 1))
                    {
                        arr[j] = arr[j+1];
                    }
                    else
                    {
                        arr[j] = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nValue (you want to delete) doesn't exist!");
                Environment.Exit(0);
            }
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

            //Print current array to screen
            Console.Write("\nCurrent array: ");
            for (int i = 0; i < arr.Length; i ++)
            {
                Console.Write(arr[i] + " ");
            }

            //Input a value that need to delete
            Console.Write("\n\nEnter a value you want to delete: ");
                int delValue = Convert.ToInt32(Console.ReadLine());

            //Excute a method
            delValueFromArray(ref arr,delValue);

            //Using minValue (function) to find min-value then print it to screen            
            Console.Write("\nYour result: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}