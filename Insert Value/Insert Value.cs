using System;
using System.Collections.Generic;
using System.Text;

namespace InsertValue
{
    class InsertValue
    {
        static void Main(string[] args)
        {   
            //Input size for array          
            Console.Write("Enter a size for array: ");
                int size = Convert.ToInt32(Console.ReadLine());

            int[] n = new int[size];

            //Input array's value            
            Console.WriteLine("Enter values for {0} elements: ",size);
            for (int i = 0; i < size; i++)
            {
                Console.Write("Value {0}: ", (i+1));
                n[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Enter a value you want to insert: ");
                int inputValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position you want to insert your value: ");
                int positionValue = Convert.ToInt32(Console.ReadLine());                            

            //Check if position is valid or not
            bool isInvalidPosition = positionValue <= 1 || positionValue > (n.Length - 1);
            // If-else Invalid
            if  (isInvalidPosition)
            {
                Console.WriteLine("Invalid position.");
            }            
            else            
            {            
                //Inserting progress    
                int insertPosition = positionValue - 1;
                int startScan = n.Length - 1;         
                for (int i = startScan; i >= insertPosition; i--)
                {          
                    if (i == insertPosition)
                    {
                        n[i] = inputValue;
                    }
                    else
                    {
                        n[i] = n[i - 1];
                    }                   
                }
                //Print array to screen
                Console.WriteLine("\nYour inserted result: ");
                for (int p = 0; p < n.Length; p++)
                {
                    Console.Write(n[p] + " ");
                }
            }
            
        }
    }
}