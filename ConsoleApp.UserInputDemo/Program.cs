namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decalre Variables

            string firstName = string.Empty;

            string lastName = string.Empty;
            int age = 0;
            int retirementAge = 67;


            //Prompt user for input

            Console.WriteLine("Please enter your first name: ");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");

            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");

            age = Convert.ToInt32(Console.ReadLine());


            //Process data

            int workingYearsLeft = retirementAge - age;


            //Display Output

            Console.WriteLine($"Your name is: {firstName} {lastName}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine($"You have {workingYearsLeft} until you can retire");

        }
    }
}
