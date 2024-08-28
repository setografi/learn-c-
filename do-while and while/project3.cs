using System;

// class Program
// {
//     static void Main()
//     {
//         string[] myStrings = new string[2] 
//         {
//             "I like pizza. I like roast chicken. I like salad",
//             "I like all three of the menu choices"
//         };

//         foreach (string myString in myStrings)
//         {
//             int periodLocation = myString.IndexOf(".");
//             while (periodLocation != -1)
//             {
//                 string sentence = myString.Substring(0, periodLocation).Trim();
//                 Console.WriteLine(sentence);
//                 myString = myString.Substring(periodLocation + 1);
//                 periodLocation = myString.IndexOf(".");
//             }
//             // Print the remaining string if there are no more periods
//             if (!string.IsNullOrWhiteSpace(myString))
//             {
//                 Console.WriteLine(myString.Trim());
//             }
//         }
//     }
// }


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}