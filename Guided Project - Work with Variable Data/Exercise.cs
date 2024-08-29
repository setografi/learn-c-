using System;

// Initialize a flag to check if no matches are found
bool noMatchesDog = true;

// Loop through the ourAnimals array to search for matching animals
for (int i = 0; i < maxPets; i++)
{
    if (ourAnimals[i, 1].Contains("dog"))
    {
        // Combine physical and personality descriptions
        string dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];

        // Search the combined descriptions for the characteristic
        if (dogDescription.Contains(dogCharacteristic))
        {
            Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
            Console.WriteLine(dogDescription);

            // Found a match, set noMatchesDog to false
            noMatchesDog = false;
        }
    }
}

// If no matches were found, display the message
if (noMatchesDog)
{
    Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
}
