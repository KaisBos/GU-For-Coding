using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMaxValue
{
    class MatrixMaxValue
    {
        static void Main(string[] args)
        {   
            //Input size of row&column for matrix
            Console.Write("Enter the size of row for matrix: ");
                int sizeRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of column for matrix: ");
                int sizeColumn = Convert.ToInt32(Console.ReadLine());

            //Declare matrix (main)
            double[,] matrix = new double[sizeRow,sizeColumn];            

            //Input for matrix
            Console.WriteLine("\nEnter value for matrix: ");
            for (int row = 0; row < sizeRow; row++)
            {
                Console.WriteLine("*Row {0}", row+1);
                for (int column = 0; column < sizeColumn; column++)
                {
                    Console.Write("Value of cell {0}: ", column+1);
                    matrix[row,column] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //Find Max Value and its position
            double maxValue = 0;            
            int rowMaxValue = 0, columnMaxValue = 0;

            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                    
                    Console.Write(matrix[i,j] + " ");
                    if (matrix[i,j] > maxValue)
                    {
                        maxValue = matrix[i,j];
                        rowMaxValue = i + 1;
                        columnMaxValue = j + 1;
                    }
                }
                Console.WriteLine();
            }

            //Print result to screen
            Console.WriteLine("\nMax value is {0}, at row {1} & column {2}.",maxValue,rowMaxValue,columnMaxValue);
        }
    }
}
