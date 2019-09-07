using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            string userName;
            double firstNumber, secondNumber;

            WriteLine("Enter you name:");
            userName = Console.ReadLine();
            WriteLine($"Welcome {userName}!");
            WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(ReadLine());
            WriteLine("Now give me another number: ");
            secondNumber = Convert.ToDouble(ReadLine());
            WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                $"{firstNumber} + {secondNumber}.");
            WriteLine($"The result of subtracting {secondNumber} from " +
                $"{firstNumber} is {firstNumber - secondNumber}");
            WriteLine($"The product of {firstNumber} and {secondNumber} " +
                $"is {firstNumber * secondNumber}.");
            WriteLine($"The result of dividing {firstNumber} by " +
                $"{secondNumber} is {firstNumber / secondNumber}");
            WriteLine($"The remainder afer dividing {firstNumber} by " +
                $"{secondNumber} is {firstNumber % secondNumber}.");
            ReadKey();
        }

    }
}
