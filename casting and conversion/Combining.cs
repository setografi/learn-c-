// combining string array values as strings and as integers challenge

// my version:
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Set the culture to en-US to handle decimal separators correctly
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        // Starter code with string array
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        // Variables to hold the concatenated message and the total sum
        string message = "";
        double total = 0.0;

        // Loop through each value in the array
        foreach (var value in values)
        {
            // Try to parse the value as a double
            if (double.TryParse(value, out double number))
            {
                // If parsing is successful, add the number to the total
                total += number;
            }
            else
            {
                // If parsing fails, treat the value as a string and concatenate to the message
                message += value;
            }
        }

        // Output the results
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
    }
}

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");