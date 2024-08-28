using System;

class Project2
{
    static void Main()
    {
        string[] validRoles = { "administrator", "manager", "user" };
        string? userInput;
        bool validRole = false;

        // Prompt the user
        Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

        do
        {
            userInput = Console.ReadLine()?.Trim().ToLower();
            if (Array.Exists(validRoles, role => role == userInput))
            {
                validRole = true;
            }
            else
            {
                Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User):");
            }
        } while (!validRole);

        // Inform the user of successful input
        Console.WriteLine($"Your input value ({userInput}) has been accepted.");
    }
}


// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();