using System;

class Program
{
    static void Main()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";

        // Split the sentence into words
        string[] words = pangram.Split(' ');

        // Reverse each word and store them in a new array
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        // Join the reversed words back into a single string
        string result = String.Join(" ", words);

        // Print the result
        Console.WriteLine(result);
    }
}


// Review a solution
// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);