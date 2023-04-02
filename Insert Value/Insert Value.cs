using System;
using System.Collections.Generic;
using System.Text;

namespace InsertValue
{
    class InsertValue
    {
        static void Main(string[] args)
        {             
            int[] n = {10,4,6,7,8,0,0,0,0,0};      
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
                bool checkedPosition;            
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
                for (int p = 0; p < n.Length; p++)
                {
                    Console.Write(n[p] + " ");
                }
            }
            
        }
    }
}