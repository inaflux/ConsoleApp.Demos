namespace ConsoleApp.ConditonsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt Input
            Console.Write("Please enter the student grade: ");
            //Global Variable/ Global Scope
            int grade = Convert.ToInt32(Console.ReadLine());

            //Decide pass or fail based on user input

            if (grade > 50)
            {
                Console.WriteLine("Student has passed the class!!!! WOOT WOOT! ");
            }
            else
            {
                Console.WriteLine("Student has failed...WOMP WOMP WOMPPPPP");
            }
            //More Complex if else statements

            Console.WriteLine("********* Complex IF ELSE **********");
            Console.WriteLine();

            if(grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input entered");
            }

            else if (grade < 50)
            {
                Console.WriteLine("Get good dawg, F!");
            }

            else if(grade >= 51 && grade <= 64)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 76 && grade <= 85)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 86 && grade <= 95)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 96 && grade <= 100)
            {
                Console.WriteLine("A");
            }

            Console.WriteLine();
            Console.WriteLine("********* Complex IF ELSE **********");




            //Ternary Operator

            string passStatus = grade < 50 ? "Fail" : "Pass";

            //Switch Statements




            Console.WriteLine("********* Switch Statement**********");
            Console.WriteLine();

            Console.WriteLine("Please enter the day of the week: ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
               
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;


            }



            Console.WriteLine();
            Console.WriteLine("********* End Switch Statment**********");
        }


        


    }
}
