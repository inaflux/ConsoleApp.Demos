using System;

namespace ConsoleApp.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Lists **********");

            //declare a list

            List<int> grades = new List<int>();
            int grade = 0;

            //var grades = new List<int>(); different way to write this syntax
            // List<int> grades = new(); different way to write this syntax

            //add values to a list
            //grades.Add(45); //now there is an index 0 
            //grades.Add(95); //now there is an index 1
            //Console.WriteLine(grades[0]);
            //Console.WriteLine(grades[1]);

            do
            {
                Console.Write("Enter Grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade != -1)
                {
                    grades.Add(grade);
                }
            } while (grade != -1);


            //print values in a list - for 
            Console.WriteLine("The grades you entered are: ");
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);

            }
            //print values in a list - foreach
            Console.WriteLine("The grades you entered are via foreach loop: ");
            foreach (int g in grades)
            {
                Console.WriteLine(g);
            }

        }
    }
}
