using System;
//This reference must be manually included.
class fibonacci
{
    static void Main()
    {
        /*Write a program to print the first 100 members of the sequence
         * of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/
        /*This could be done with decimal data type, and i suspect that
         * it might be faster, but i wanted to try out the "BigInteger"*/
        double predecessor = 0;
        double currentMember = 1;
        Console.WriteLine(predecessor);
        Console.WriteLine(currentMember);
        double buffer;
        for (int i = 0; i < 100; i++)
        {
            buffer = predecessor;
            predecessor = currentMember;
            currentMember = predecessor + buffer;
            Console.WriteLine("{0}", currentMember);
        }
    }
}
