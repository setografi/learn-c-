// Complete a challenge to parse a string of orders, sort the orders and tag possible errors

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Data input
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        // Pisahkan Order IDs dan simpan dalam array
        string[] orderIds = orderStream.Split(',');

        // Urutkan Order IDs
        var sortedOrderIds = orderIds.OrderBy(id => id).ToArray();

        // Tampilkan hasil dengan tag Error jika panjang tidak sama dengan 4
        foreach (var id in sortedOrderIds)
        {
            if (id.Length == 4)
            {
                Console.WriteLine(id);
            }
            else
            {
                Console.WriteLine($"{id} - Error");
            }
        }
    }
}

// Review a solution
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}