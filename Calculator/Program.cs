using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                int num1;
                int num2;
                int result;

                Console.WriteLine("Hi there! I'm the faster calculator in the world, ask me anything");

                // Prompt for the first number
                Console.WriteLine("Enter the first number: ");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Please enter a valid integer number for the first number:");
                }

                // Prompt for the second number
                Console.WriteLine("Please enter your second number: ");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Please enter a valid integer number for the second number:");
                }

                // Prompt for the operation
                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or any other key for division.");

                answer = Console.ReadLine();

                // Perform the calculation based on the user's choice
                switch (answer)
                {
                    case "a":
                        result = num1 + num2;
                        break;
                    case "s":
                        result = num1 - num2;
                        break;
                    case "m":
                        result = num1 * num2;
                        break;
                    default:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        break;
                }

                // Display the result
                Console.WriteLine("Here is the result: " + result);

                // Ask the user if they want to perform another calculation
                Console.WriteLine("Do you want to do another math? Yes or No?");
                answer = Console.ReadLine().Trim().ToLower();

            } while (answer == "yes");

        }
    }
}
