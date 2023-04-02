using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTemperature
{
    class ConvertTemperature
    {        
        public static void Main(string[] args)
        {   
            int choice = -6;
            while (choice != 0)
            {                
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Fahrenheit to celsius");
                Console.WriteLine("2. Celsius to fahrenheit");
                Console.WriteLine("0. Exit");

                Console.WriteLine("\nYour choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Fahrenheit: ");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());                    
                        Console.WriteLine("Your converted Celcius: {0}", fahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.Write("Enter Celcius: ");
                        double celcius = Convert.ToDouble(Console.ReadLine());                        
                        Console.WriteLine("Your converted Fahrenheit: {0}", celciusToFahrenheit(celcius));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        public static double fahrenheitToCelsius(double fahrenheit)
        {
            double convertedCelcius = (5.0 / 9) * (fahrenheit - 32);
            convertedCelcius = Math.Round(convertedCelcius,1);
            return convertedCelcius;
        }

        public static double celciusToFahrenheit(double celcius)
        {
            double convertedFahrenheit = (9.0 / 5) * celcius + 32;
            convertedFahrenheit = Math.Round(convertedFahrenheit,1);
            return convertedFahrenheit;
        }        
    }
}