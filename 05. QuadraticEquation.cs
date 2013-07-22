//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).


using System;

class quadraticEquation
{
    static void Main()
    {
        float a, b, c;
        Console.Write("Enter a:");
        while (!float.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid input. Please try again.\nEnter a:");
        }
        Console.Write("Enter b:");
        while (!float.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid input. Please try again.\nEnter b:");
        }
        Console.Write("Enter c:");
        while (!float.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid input. Please try again:\nEnter c:");
        }
        float discriminant = b * b - 4 * a * c;
        double discriminantSquareRoot = (float)Math.Sqrt(Math.Abs(discriminant));
        double discriminantSquareRootDecimal = (discriminantSquareRoot - (int)discriminantSquareRoot);
        string relationType = (((discriminantSquareRootDecimal * 10000) == (int)(discriminantSquareRootDecimal * 1000)) ? "=" : " is approximately ");
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Every X is a root." : "No real or complex roots.");
            }
            else
            {
                Console.WriteLine("Linear equation. Only one root.");
                Console.WriteLine("X={0}", -c / b);
            }
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("Two real roots.\nX1{2}{0:0.000}\nX2{2}{1:0.000}"
                , (-b - Math.Sqrt(discriminant)) / (2 * a), (-b + Math.Sqrt(discriminant)) / (2 * a), relationType);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("One double root.\nX1=X2={0}", -b / 2 * a);
        }
        else
        {
            Console.WriteLine("No real roots!!!\nComplex roots!!!");
            Console.WriteLine("X1{3}({0}+({1:0.0000}*i))/{2}", -b, Math.Sqrt(-discriminant), 2 * a, relationType);
            Console.WriteLine("X2{3}({0}+({1:0.0000}*i))/{2}", b, Math.Sqrt(-discriminant), 2 * a, relationType);
        }
    }
}
