//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;
class ThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads three numbers and prints their Sum.");
        Console.WriteLine("Please provide value for the first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please provide value for the second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Please provide value for the third number: ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("You have provided the following three numbers {0}, {1} and {2}.\nTheir sum is {3}.", a,b,c,a+b+c);

    }
}
