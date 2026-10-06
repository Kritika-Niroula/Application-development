using System;

class Circle
{
    public const double PI = 3.14;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("PI = " + Circle.PI);

        // Try to modify PI
        Circle.PI = 3.14159;
    }
}