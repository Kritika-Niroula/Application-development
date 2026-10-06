using System;

class Program
{
    static void Main()
    {
        // Birthdate
        DateTime birthDate = new DateTime(2006, 4, 9);

        // Current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate the difference
        TimeSpan difference = currentDate - birthDate;

        // Calculate age in years
        int age = currentDate.Year - birthDate.Year;

        if (currentDate < birthDate.AddYears(age))
        {
            age--;
        }

        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate);
        Console.WriteLine("Age: " + age + " years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine("Birthdate after 10 days: " + newDate.ToShortDateString());
    }
}