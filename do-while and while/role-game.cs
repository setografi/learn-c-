using System;

class Program
{
    static void Main()
    {
        // Initialize random number generator
        Random random = new Random();
        
        // Initialize health points
        int heroHealth = 10;
        int monsterHealth = 10;

        // Battle loop
        while (heroHealth > 0 && monsterHealth > 0)
        {
            // Hero's turn
            int heroAttack = random.Next(1, 11); // Random value between 1 and 10
            monsterHealth -= heroAttack;
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            // Check if monster is defeated
            if (monsterHealth <= 0)
            {
                break;
            }

            // Monster's turn
            int monsterAttack = random.Next(1, 11); // Random value between 1 and 10
            heroHealth -= monsterAttack;
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
        }

        // Determine the winner
        if (heroHealth > 0)
        {
            Console.WriteLine("Hero wins!");
        }
        else
        {
            Console.WriteLine("Monster wins!");
        }
    }
}

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");