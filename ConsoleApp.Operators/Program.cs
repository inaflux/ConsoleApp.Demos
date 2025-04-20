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
            Console.WriteLine("********** MATH RESULTS **********");
            Console.WriteLine();
            Console.WriteLine($"The sum of {num1} + {num2} is: {sum}");
            Console.WriteLine($"The product of {num1} * {num2} is: {product}");
            Console.WriteLine($"The quotient of {num1} / {num2} is: {quotient}");
            Console.WriteLine($"The difference between {num1} - {num2} is: {difference}");
            Console.WriteLine($"The modulus of {num1} % {num2} is {mod}");
            Console.WriteLine();
            Console.WriteLine("********** END OF MATH RESULTS **********");


            //Logic Operators

            bool isGreaterThan = num1 > num2;
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;
            bool isNotEqualTo = num1 != num2;


            Console.WriteLine("********** LOGICAL OPERATORS RESULTS **********");
            Console.WriteLine();
            Console.WriteLine($"{num1} > {num2} is: {isGreaterThan}");
            Console.WriteLine($"{num1} < {num2} is: {isLessThan}");
            Console.WriteLine($"{num1} == {num2} is: {isEqualTo}");
            Console.WriteLine($"{num1} >= {num2} is: {isGreaterThanOrEqualTo}");
            Console.WriteLine($"{num1} <= {num2} is: {isLessThanOrEqualTo}");
            Console.WriteLine($"{num1} != {num2} is: {isNotEqualTo}");
            Console.WriteLine();
            Console.WriteLine("********** END OF LOGICAL OPERATORS RESULTS **********");


            //Assignment Operators






            Console.WriteLine("********** ASSIGNMENT OPERATORS RESULTS **********");
            Console.WriteLine();
            num1 += 4;
            Console.WriteLine($"Number 1 increased by 4: {num1}");
            num1 -= 2;
            Console.WriteLine($"Number 1 decreased by 2: {num1}");
            num1 /= 7;
            Console.WriteLine($"Number 1 divided by  7: {num1}");
            num1 %= 3;
            Console.WriteLine($"Number 1 mod by 3: {num1}");
            num1 *= 20;
            Console.WriteLine($"Number 1 multiplied by 20:  {num1}");

            Console.WriteLine();
            Console.WriteLine("********** END OF ASSIGNMENT OPERATORS RESULTS **********");


        }
    }
}
