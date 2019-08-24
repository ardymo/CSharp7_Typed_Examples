using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string userName;
            double firstNumber, secondNumber;

            Console.WriteLine("Enter you name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                $"{firstNumber} + {secondNumber}.");
            Console.WriteLine($"The result of subtracting {secondNumber} from " +
                $"{firstNumber} is {firstNumber - secondNumber}");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} " +
                $"is {firstNumber * secondNumber}.");
            Console.WriteLine($"The result of dividing {firstNumber} by " +
                $"{secondNumber} is {firstNumber / secondNumber}");
            Console.WriteLine($"The remainder afer dividing {firstNumber} by " +
                $"{secondNumber} is {firstNumber % secondNumber}.");
            Console.ReadKey();
        }

    }
}
