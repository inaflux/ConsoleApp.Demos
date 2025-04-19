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
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = true;


            //Prompt user for input

            Console.WriteLine("Please enter your first name: ");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");

            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your salary: ");

            salary = Convert.Decimal(Console.ReadLine());

            Console.WriteLine("Please enter your gender (M or F): ");

            gender = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Are you working? (true or false) ");

            working = Convert.ToBoolean(Console.ReadLine());

            //Process data

            int workingYearsLeft = retirementAge - age;


            //Display Output

            Console.WriteLine($"Your name is: {firstName} {lastName}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine($"You have {workingYearsLeft} until you can retire");

        }
    }
}
