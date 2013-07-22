/*Write a program that gets a number n and after 
 * that gets more n numbers and calculates and prints their sum.*/

using System;

class sumOfNNumbers
{
    static void Main()
    {
        uint n;
        Console.Write("Enter N (number of entries):");
        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("invalid entry. Please try again: ");
        }
        int sum = 0;
        int buffer;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0} :", i);
            while (!int.TryParse(Console.ReadLine(), out buffer))
            {
                Console.Write("invalid entry. Please try again: ");
            }
            sum = sum + buffer;

        }
        Console.WriteLine("The sum of the numbers is {0}", sum);
    }
}
