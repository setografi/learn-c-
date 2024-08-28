using System;

class Project1
{
    static void Main()
    {
        int userInput;
        bool validNumber = false;

        // Prompt the user
        Console.WriteLine("Enter an integer value between 5 and 10:");

        do
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out userInput))
            {
                if (userInput >= 5 && userInput <= 10)
                {
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("You entered {0}. Please enter a number between 5 and 10.", userInput);
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again.");
            }
        } while (!validNumber);

        // Inform the user of successful input
        Console.WriteLine($"Your input value ({userInput}) has been accepted.");
    }
}

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();