using System;

class Program
{
    static void Main(string[] args)
    {
        // Inisialisasi variabel
        int currentAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        int[] sophiaExtraCredit = new int[] { 89, 89, 89, 89, 89 };
        int[] andrewExtraCredit = new int[] { 80, 89, 81, 90, 91 };
        int[] emmaExtraCredit = new int[] { 85, 92, 85, 95, 89 };
        int[] loganExtraCredit = new int[] { 93, 96, 94, 92, 95 };

        CalculateAndPrintGrade("Sophia", sophiaScores, sophiaExtraCredit, currentAssignments);
        CalculateAndPrintGrade("Andrew", andrewScores, andrewExtraCredit, currentAssignments);
        CalculateAndPrintGrade("Emma", emmaScores, emmaExtraCredit, currentAssignments);
        CalculateAndPrintGrade("Logan", loganScores, loganExtraCredit, currentAssignments);

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }

    static void CalculateAndPrintGrade(string studentName, int[] examScores, int[] extraCreditScores, int totalAssignments)
    {
        int examSum = 0;
        int extraCreditSum = 0;

        // Menghitung total nilai ujian dan nilai tambahan
        foreach (int score in examScores)
        {
            examSum += score;
        }

        foreach (int score in extraCreditScores)
        {
            extraCreditSum += score;
        }

        // Menghitung rata-rata nilai ujian
        decimal examAverage = (decimal)examSum / totalAssignments;

        // Menghitung 10% dari nilai ekstra
        decimal extraCreditPercent = (decimal)extraCreditSum * 0.1m;

        // Menghitung nilai total akhir
        decimal finalScore = (examSum + extraCreditPercent) / totalAssignments;

        // Menghitung poin nilai ekstra yang diperoleh
        decimal extraCreditPoints = extraCreditPercent / totalAssignments;

        // Menentukan huruf grade
        string grade = DetermineGrade(finalScore);

        // Menampilkan hasil
        Console.WriteLine($"{studentName}\t\t{examAverage:F1}\t\t{finalScore:F2}\t{grade}\t{extraCreditSum} ({extraCreditPoints:F2} pts)");
    }

    static string DetermineGrade(decimal finalScore)
    {
        if (finalScore >= 90)
            return "A";
        else if (finalScore >= 80)
            return "B";
        else if (finalScore >= 70)
            return "C";
        else if (finalScore >= 60)
            return "D";
        else
            return "F";
    }
}
