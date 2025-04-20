namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            //Add numbers

            int sum = num1 + num2;

            //Multiply numbers

            int product = num1 * num2;

            //Divide numbers

            int quotient = num1 / num2;

            //Subtract numbers
            int difference = num1 - num2;

            //Modulus 
            int mod = num1 % num2;

            //Display output

            Console.WriteLine($"The sum of {num1} + {num2} is: {sum}");
            Console.WriteLine($"The product of {num1} * {num2} is: {product}");
            Console.WriteLine($"The quotient of {num1} / {num2} is: {quotient}");
            Console.WriteLine($"The difference between {num1} - {num2} is: {difference}");
            Console.WriteLine($"The modulus of {num1} % {num2} is {mod}");


        }
    }
}
