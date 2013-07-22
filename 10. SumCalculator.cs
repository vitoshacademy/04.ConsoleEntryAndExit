using System;
class Program
{
    static void Main()
    {
        decimal now = 2;
        decimal sum = 1;
        int sign = 1;
        while (now <= 100)
        {
            sum = sum + 1 / (sign * now);
            now = now + 1;
            sign = sign * (-1);
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}
