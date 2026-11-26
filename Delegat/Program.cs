using System;

class Delegat
{
    delegate void Operation(int a, int b);

    static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    static void Calculate(int a, int b, Operation operation)
    {
        operation(a, b);
    }

    static void Main(string[] args)
    {

        Calculate(20, 4, Add);
        Calculate(20, 4, Sub);

    }
}