// Can you remove null elements from an array?

using System;

class Program
{
    static void Main()
    {
        // Array awal dengan beberapa elemen null
        string[] originalArray = { "Apple", null, "Banana", null, "Cherry", "Date", null };

        // Hitung jumlah elemen non-null
        int count = 0;
        foreach (var item in originalArray)
        {
            if (item != null)
            {
                count++;
            }
        }

        // Buat array baru dengan ukuran yang sesuai
        string[] cleanedArray = new string[count];

        // Salin elemen non-null ke array baru
        int index = 0;
        foreach (var item in originalArray)
        {
            if (item != null)
            {
                cleanedArray[index] = item;
                index++;
            }
        }

        // Tampilkan hasil
        Console.WriteLine("Array setelah menghapus elemen null:");
        foreach (var item in cleanedArray)
        {
            Console.WriteLine(item);
        }
    }
}
