using System;
using System.Collections.Generic;
using System.Text;

namespace CountCharUsingMethod
{
    class CountCharUsingMethod
    {        
        public static int CountChar(string text, char charNeedCount)
        {
            int lengthText = text.Length;
            int count = 0;
            for (int i = 0; i < lengthText; i ++)
            {
                if (text[i] == charNeedCount)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {   
            //Input text
            string text;
            Console.Write("Enter text: ");
                text = Console.ReadLine();
            
            //Input char to count
            char charNeedCount;
            Console.Write("Enter a char you wanna count: ");
                charNeedCount = Convert.ToChar(Console.ReadLine());

            //Print the result using method
            Console.Write("Total counts of '{0}' char: {1}", charNeedCount,CountChar(text, charNeedCount));
        }
    }
}