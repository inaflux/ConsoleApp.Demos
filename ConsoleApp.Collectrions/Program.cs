namespace ConsoleApp.Collectrions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Arrays ***********");

            //Declare a fixed size array
            int[] grades = new int[5];  //5 space indexes - 0, 1, 2, 3, 4

            //Add values to fixed size array
            //grades[0] = 45;
            //grades[1] = 25;
            //grades[2] = 33;
            //grades[3] = 56;
            //grades[4] = 22;

            for (int i = 0; i < grades.Length ; i++)
            {
                Console.Write("Enter Grade: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Print values in a fixed size array
            Console.WriteLine("The grades you have entered are: ");

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);

            }

            //Declare variable sized array

            string[] studentNames = { "newtone", "josh", "etc..."};

            //Add values to variable sized array
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write("Enter student name: ");
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine("The student names you have entered are: ");

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i]);

            }
        }
    }
}
