
using System;


namespace Max_Value
{
    class Max_Value
    {
        static void Main(string[] args)
        {   
            int size;
            int[] Value;

            do
            {
                Console.Write("Enter a size: ");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");             
            } while (size > 20);

            Value = new int[size];

            for (int i = 0; i < Value.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                Value[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int maxValue = Value[0];
            int index = 1;

            Console.WriteLine("Property list: ");
            for (int j = 0; j < Value.Length; j++)
            {
                Console.WriteLine(Value[j] + "\t");
                if (Value[j] > maxValue)
                {
                    maxValue = Value[j];
                    index = j+1;
                }
            }

            Console.WriteLine("The largest property value in the list is {0}, at position {1}.", maxValue, index);            
        }   
    }
}