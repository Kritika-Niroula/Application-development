using System;

class Program
{
    static void Main()
    {
        byte byteValue = 10;
        short shortValue = 20;
        int intValue = 42;
        long longValue = 100000;
        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

        // Convert integer 42 to string
        string intToString = intValue.ToString();

        // Convert string "3.14" to double
        double stringToDouble = Convert.ToDouble("3.14");

        Console.WriteLine("byte: " + byteValue);
        Console.WriteLine("short: " + shortValue);
        Console.WriteLine("int: " + intValue);
        Console.WriteLine("long: " + longValue);
        Console.WriteLine("float: " + floatValue);
        Console.WriteLine("double: " + doubleValue);
        Console.WriteLine("decimal: " + decimalValue);
        Console.WriteLine("char: " + charValue);
        Console.WriteLine("bool: " + boolValue);

        Console.WriteLine("Integer to String: " + intToString);
        Console.WriteLine("String to Double: " + stringToDouble);
    }
}