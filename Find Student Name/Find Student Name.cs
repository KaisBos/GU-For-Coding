
using System;


namespace Find_Student_Name
{
    class Find_Student_Name
    {
        static void Main(string[] args)
        {   
            string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            bool isExist = false;

            Console.WriteLine("Enter a name's student: ");
            string input_name = Console.ReadLine();
            

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == input_name)
                {
                    Console.WriteLine("Position of student named {0} in the list is {1}", input_name, (i+1));
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                Console.WriteLine("Not found {0} in the list.", input_name);
            }
        }   
    }
}