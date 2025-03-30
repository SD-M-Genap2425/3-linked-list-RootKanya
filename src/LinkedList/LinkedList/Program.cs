namespace LinkedList;

using LinkedList.Perpustakaan;
using LinkedList.ManajemenKaryawan;
using LinkedList.Inventori;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        string output1 = PerpustakaanApp.Run();
        Console.WriteLine(output1);

        // Soal ManajemenKaryawan
        string output2 = ManajemenKaryawanApp.Run();
        Console.WriteLine(output2);

        // Soal Inventori
        string output3 = ManajemenInventori.Run();
        Console.WriteLine(output3);
    }
}
