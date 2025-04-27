namespace ConsoleApp.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Methods **********");

            
            //Void methods- completes a task without returning a value

            void PrintName()
            {
                Console.WriteLine("Jacob Henderson");
            }

            //Value returning methods - returns a value after an operation

            int GetFiveYearsAgo()
            {
                int year = DateTime.Now.AddYears(-5).Year;
                return year;
            }

            //methods with parameters - data being passed into a method


            void PrintNameWithParams(string name)
            {
                Console.WriteLine(name);
            }

            int GetFiveDifferenceWithParams(int year)
            {
                int yearDifference = DateTime.Now.Year - year;
                return yearDifference;
            }


            //methods with optional parameters - parameter is not required and has a default value
            int GetFutureOrPastYear(int numberOfYears = 0) 
            {
                var year = DateTime.Now.AddYears(numberOfYears).Year;
                return year;
            }
            //methods with nullable parameters

            /* Function Calls */
            PrintName();
            int fiveYearsAgo = GetFiveYearsAgo();
            Console.WriteLine($"Five years ago was: {fiveYearsAgo}");

            Console.WriteLine("Enter your name: ");
            string name1 = Console.ReadLine();
            PrintNameWithParams(name1);


            Console.WriteLine("Enter a year: ");
            int pastYear = Convert.ToInt32(Console.ReadLine());
            int yearsAgo = GetFiveDifferenceWithParams(pastYear);
            Console.WriteLine($"This was {yearsAgo} years ago");

            Console.WriteLine("Enter number of year in the future or past: ");
            int numberOfYears = Convert.ToInt32(Console.ReadLine());

            int pastYear1 = GetFutureOrPastYear();
            Console.WriteLine("The year is: " + pastYear1);

            var pastYear2 = GetFutureOrPastYear(numberOfYears);
            Console.WriteLine("The year is: " + pastYear2);


            



        }
    }
}
