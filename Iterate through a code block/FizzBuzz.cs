using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            // Initialize output variable
            string output = i.ToString();

            // Check if divisible by 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                output += " - FizzBuzz";
            }
            // Check if divisible by 3
            else if (i % 3 == 0)
            {
                output += " - Fizz";
            }
            // Check if divisible by 5
            else if (i % 5 == 0)
            {
                output += " - Buzz";
            }

            // Print the result
            Console.WriteLine(output);
        }
    }
}

// for (int i = 1; i < 101; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }