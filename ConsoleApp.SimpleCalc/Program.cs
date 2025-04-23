namespace ConsoleApp.SimpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Simple Calculator ************");
            Console.WriteLine();

            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int sum = num1 + num2;

            //Multiply numbers

            int product = num1 * num2;

            //Divide numbers

            int quotient = num1 / num2;

            //Subtract numbers
            int difference = num1 - num2;

            //Modulus 
            int mod = num1 % num2;


            //Show Calculator Options
            Console.WriteLine("Welcome to the simple calculator. Here are your options: ");
            Console.WriteLine("Enter A for addition");
            Console.WriteLine("Enter S for subtraction");
            Console.WriteLine("Enter M for multiplication");
            Console.WriteLine("Enter D for division");
            Console.WriteLine("Enter R for modulous");
            string operationChoice = Console.ReadLine();

            //Decide which opertation is needed based on selected option
            if (operationChoice == "A" )
            {
                Console.Write($"You chose to add {num1} to {num2} and the answer is: {sum}");
            }

            else if (operationChoice == "S")
            {
                Console.Write($"You chose to subtract {num1} from {num2} and the answer is: {difference}");
            }
            else if (operationChoice == "M")
            {
                Console.Write($"You chose to multiply {num1} by {num2} and the answer is: {product}");
            }
            else if (operationChoice == "D")
            {
                Console.Write($"You chose to divide {num1} by {num2} and the answer is: {quotient}");
            }
            else if (operationChoice == "R")
            {
                Console.Write($"You chose to find the modulus of  {num1} / {num2} and the answer is: {mod}");
            }
            //Print output
            Console.WriteLine();
            Console.WriteLine("*********** Simple Calculator ************");
        }
    }
}
