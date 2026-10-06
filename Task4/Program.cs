using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 7, 3, 9, 1, 5 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element using a for loop
        Console.WriteLine("Array elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a specific number
        int numberToFind = 5;
        int position = Array.IndexOf(numbers, numberToFind);

        Console.WriteLine("Position of " + numberToFind + ": " + position);
    }
}