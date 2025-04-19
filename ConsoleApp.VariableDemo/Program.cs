using System.Runtime.CompilerServices;

namespace ConsoleApp.VariableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             string - text
             int - numbers
             decimal - double, float, decimal
             bool - logical true or false
             */

            string name;

            name = "Jacob Henderson";

            Console.WriteLine(name);

            Console.WriteLine("Hi, my name is " + name); // String concatenation

            Console.WriteLine($"I saiddddd, my name is {name}"); //String interpolation

            Console.WriteLine("Why will you not listen to me!! My name is {0}", name); //Formatted string


            int age = 903;

            Console.WriteLine($"Yooo, my age is {age}");



            int retirementYearsLeft = 97;

            int retirementAge = age + retirementYearsLeft;

            Console.WriteLine($"Retirement Age: {retirementAge}");


            bool isRetired = false;

            Console.WriteLine($"Am I retired? {isRetired}");



        }
    }
}
