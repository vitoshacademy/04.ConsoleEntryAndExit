//Write a program that reads an integer number n from the console 
//and prints all the numbers in the interval [1..n], each on a single line.


using System;

class IntegerN
{
    static void Main(string[] args)
    {
        uint n;
        int i ;
        Console.Write("Enter N:");
        while (!uint.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.Write("invalid entry. Please try again: ");
        }
        for (i = 1; i <= n; i++)
        {
            Console.WriteLine("N: {0}", i);
        }
    }
}
