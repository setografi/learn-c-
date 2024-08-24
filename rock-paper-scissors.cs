using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Selamat datang di permainan Batu, Gunting, Kertas!");
            Console.WriteLine("Pilih salah satu: Batu, Gunting, atau Kertas.");

            string userChoice = Console.ReadLine().ToLower();
            string computerChoice = GetComputerChoice();

            Console.WriteLine($"\nKamu memilih: {userChoice}");
            Console.WriteLine($"Komputer memilih: {computerChoice}");

            string result = DetermineWinner(userChoice, computerChoice);
            Console.WriteLine($"\nHasil: {result}");

            Console.WriteLine("\nApakah kamu ingin bermain lagi? (y/n)");
            string response = Console.ReadLine().ToLower();

            playAgain = (response == "y");
        }

        Console.WriteLine("Terima kasih sudah bermain!");
    }

    static string GetComputerChoice()
    {
        Random random = new Random();
        int choice = random.Next(1, 4); // Menghasilkan angka antara 1 dan 3

        switch (choice)
        {
            case 1:
                return "batu";
            case 2:
                return "gunting";
            case 3:
                return "kertas";
            default:
                return "batu";
        }
    }

    static string DetermineWinner(string userChoice, string computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return "Seri!";
        }
        else if ((userChoice == "batu" && computerChoice == "gunting") ||
                 (userChoice == "gunting" && computerChoice == "kertas") ||
                 (userChoice == "kertas" && computerChoice == "batu"))
        {
            return "Kamu menang!";
        }
        else if ((computerChoice == "batu" && userChoice == "gunting") ||
                 (computerChoice == "gunting" && userChoice == "kertas") ||
                 (computerChoice == "kertas" && userChoice == "batu"))
        {
            return "Komputer menang!";
        }
        else
        {
            return "Pilihan tidak valid!";
        }
    }
}
