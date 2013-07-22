/* Write a program that reads two positive integer numbers and prints how many numbers
   p exist between them such that the reminder of the 
   division by 5 is 0 (inclusive). Example: p(17,25) = 2.*/


using System;
class TwoPositiveNumbers
{
    static void Main()
    {
        int firstNumber;
        Console.Write("Enter the first number:");
        while(!int.TryParse(Console.ReadLine(),out firstNumber))
        {
            Console.Write("Incorrect input. Please try again:");
        }
        int secondNumber;
        Console.Write("Enter the second number:");
        while(!int.TryParse(Console.ReadLine(),out secondNumber))
        {
            Console.Write("Incorrect input. Please try again:");
        }
        Console.WriteLine("The number of divisible numbers in the interval [{0},{1}] is {2}.",
            firstNumber, secondNumber,
            ((Math.Abs(firstNumber - secondNumber) + Math.Min(firstNumber, secondNumber) % 5) / 5)
            + (Math.Min(firstNumber, secondNumber) % 5 == 0 ? 1 : 0));
    }
}
