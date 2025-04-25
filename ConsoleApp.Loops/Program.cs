using System.Runtime.InteropServices;

namespace ConsoleApp.Loops
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //For Loops
            Console.WriteLine("********** For Loop ***********");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Hello, World! - {i} ");
            }

            Console.WriteLine();
            Console.WriteLine("********** End For Loop ***********");

            //Ask user how manytimes they want to print hello world 
            /*Console.WriteLine("How many times do you want to print hello world? ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userChoice; i++)
            {

                Console.WriteLine($"Hello, World! - {i} ");
            }
            */

            //While Loop 

            Console.WriteLine("********** While Loop ***********");
            Console.WriteLine();

            int counter = 0;
            while (counter < 10)
            {

                Console.WriteLine($"Hello, World! - {counter} ");
                counter += 3;
            }

            //Ask the user for a number and find the total for each number that is entered . Print finaly sum when thew user -1 to exit.

            int currentTotal = 0;
            int loopNumber = 0;

            bool keepGoing = true;
            /*
            while (keepGoing)
            {
                
                Console.Write("Please enter a number or -1 to EXIT: ");
                loopNumber = Convert.ToInt32(Console.ReadLine());

                
                if (loopNumber != -1)
                {
                    currentTotal += loopNumber;
                }
                

                Console.WriteLine($"{currentTotal}");

                if (loopNumber == -1)
                {
                    Console.Write($"Final total: {currentTotal}");
                    keepGoing = false;
                }
            }

            */

            Console.WriteLine();
            Console.WriteLine("********** End While Loop ***********");


            //Do While Loop

            Console.WriteLine("********** Do While Loop ***********");
            Console.WriteLine();

            currentTotal = 0;
            loopNumber = 0;
            do
            {
                Console.Write("Please enter a number or -1 to EXIT: ");
                loopNumber = Convert.ToInt32(Console.ReadLine());

                
                
                if (loopNumber != -1)
                {
                    currentTotal += loopNumber;
                }

                if (loopNumber == -1)
                {
                    Console.Write($"Final total: {currentTotal}");
                    keepGoing = false;
                }
                Console.WriteLine($"{currentTotal}");

            } while (keepGoing);
       



            Console.WriteLine();
            Console.WriteLine("********** End Do While Loop ***********");


        }
    }
}
