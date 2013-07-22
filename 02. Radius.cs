//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hi! This program reads the radius of a circle and prints its perimeter and area");
        Console.WriteLine("Please give value for the radius in centimeters: ");
        double pi = 3.14;
        double r = double.Parse(Console.ReadLine());
        double area = Math.Pow(pi,2)*pi;
        double perimeter = 2*pi*r;

        Console.WriteLine("You have entered value for radius - {0}", r);
        Console.WriteLine("Thus, the perimeter is {0} and the area is {1}!\n\nHave fun! ",perimeter, area  );

    }
}
