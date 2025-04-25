using System;

namespace ConsoleApp.SimpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            if (operationChoice == "A")
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

            else if(operationChoice == "X")
            {
                keepGoing = false;
            }*/

            Console.WriteLine("*********** Simple Calculator ************");
            Console.WriteLine();


            char operationChoice;
            int num1, num2 = 0;
            bool keepGoing = true;


            //Decide which opertation is needed based on selected option
            while (keepGoing)
            {
                try
                {
                    Console.WriteLine("Welcome to the simple calculator. Here are your options: ");
                    Console.WriteLine("Enter A for addition");
                    Console.WriteLine("Enter S for subtraction");
                    Console.WriteLine("Enter M for multiplication");
                    Console.WriteLine("Enter D for division");
                    Console.WriteLine("Enter R for modulous");
                    Console.WriteLine("Enter X to Exit");                   
                    operationChoice = Convert.ToChar(Console.ReadLine());
                  
                    if (operationChoice == 'X')
                    {
                        keepGoing = false;
                        break;
                    }

                    
                     Console.Write("Please enter the first number: ");
                     num1 = Convert.ToInt32(Console.ReadLine());


                     Console.Write("Please enter the second number: ");
                     num2 = Convert.ToInt32(Console.ReadLine());

                    int answer = 0;


                    switch (operationChoice)
                    {

                        case 'A':
                            answer = num1 + num2;
                            Console.WriteLine($"You chose to add {num1} to {num2} and the answer is: {answer}");
                            break;
                        case 'S':
                            answer = num1 / num2;
                            Console.WriteLine($"You chose to subtract {num1} from {num2} and the answer is: {answer}");
                            break;

                        case 'M':
                            answer = num1 * num2;
                            Console.WriteLine($"You chose to multiply {num1} by {num2} and the answer is: {answer}");
                            break;

                        case 'D':
                            
                            answer = num1 / num2;
                            Console.WriteLine($"You chose to divide {num1} by {num2} and the answer is: {answer}");
                            break;

                        case 'R':
                            answer = num1 % num2;
                            Console.WriteLine($"You chose to find the modulus of  {num1} % {num2} and the answer is: {answer}");
                            break;

                        default:
                            throw new Exception("Invalid Choice Selected");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Contine: ");
                    Console.ReadLine();
                    Console.WriteLine();

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannont divide by 0");
                    Console.ReadLine();
                    Console.Clear();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press any key to try again:");
                    Console.ReadLine();
                    Console.Clear();
                    
                   
                }
              
            }

            Console.WriteLine();
            Console.WriteLine("*********** End Of Simple Calculator ************");
        }
    }
}
