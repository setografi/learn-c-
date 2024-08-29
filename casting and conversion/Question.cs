using System;

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// mengonversi string second menjadi tipe numerik menggunakan metode konversi yang sesuai.

int first = 2;
string second = "4";
int secondNumber = Convert.ToInt32(second); // Konversi string ke int
int result = first + secondNumber; // Operasi penjumlahan dengan tipe yang sama
Console.WriteLine(result);
