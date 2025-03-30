namespace LinkedList.ManajemenKaryawan;

using System.Collections.Generic;
using System.Text;

public class Karyawan
{
    public string NomorKaryawan { get; }
    public string Nama { get; }
    public string Posisi { get; }

    public Karyawan(string nomorKaryawan, string nama, string posisi)
    {
        NomorKaryawan = nomorKaryawan;
        Nama = nama;
        Posisi = posisi;
    }
}

public class KaryawanNode
{
    public Karyawan Data { get; }
    public KaryawanNode? Next { get; set; }
    public KaryawanNode? Prev { get; set; } 

    public KaryawanNode(Karyawan karyawan)
    {
        Data = karyawan;
        Next = null;
        Prev = null;
    }
    
    public Karyawan Karyawan => Data;
}

public class DaftarKaryawan
{
    private KaryawanNode? head; 
    private KaryawanNode? tail;

    public void TambahKaryawan(Karyawan karyawan)
    {
        KaryawanNode newNode = new KaryawanNode(karyawan);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    public bool HapusKaryawan(string nomorKaryawan)
    {
        KaryawanNode? temp = head;
        while (temp != null)
        {
            if (temp.Data.NomorKaryawan == nomorKaryawan)
            {
                if (temp.Prev != null)
                {
                    temp.Prev.Next = temp.Next;
                }
                else
                {
                    head = temp.Next;
                }

                if (temp.Next != null)
                {
                    temp.Next.Prev = temp.Prev;
                }
                else
                {
                    tail = temp.Prev;
                }
                return true;
            }
            temp = temp.Next;
        }
        return false;
    }

    public Karyawan[] CariKaryawan(string kataKunci)
    {
        List<Karyawan> hasil = new List<Karyawan>();
        KaryawanNode? temp = head;
        while (temp != null)
        {
            if (temp.Data.Nama.Contains(kataKunci) || temp.Data.Posisi.Contains(kataKunci))
            {
                hasil.Add(temp.Data);
            }
            temp = temp.Next;
        }
        return hasil.ToArray();
    }

    public string TampilkanDaftar()
    {
        StringBuilder sb = new StringBuilder();
        KaryawanNode? temp = tail;
        while (temp != null)
        {
            sb.AppendLine($"{temp.Data.NomorKaryawan}; {temp.Data.Nama}; {temp.Data.Posisi}");
            temp = temp.Prev;
        }
        return sb.ToString().TrimEnd();
    }
}

public class ManajemenKaryawanApp
{
    public static string Run()
    {
        StringBuilder sb = new StringBuilder();
        DaftarKaryawan daftar = new DaftarKaryawan();

        daftar.TambahKaryawan(new Karyawan("001", "John Doe", "Manager"));
        daftar.TambahKaryawan(new Karyawan("002", "Jane Doe", "HR"));
        daftar.TambahKaryawan(new Karyawan("003", "Bob Smith", "IT"));

        sb.AppendLine("Daftar Karyawan Awal:");
        sb.AppendLine(daftar.TampilkanDaftar());
        sb.AppendLine();

        sb.AppendLine("Menghapus '002'...");
        bool berhasil = daftar.HapusKaryawan("002");
        sb.AppendLine(berhasil ? "Karyawan berhasil dihapus." : "Karyawan tidak ditemukan.");
        sb.AppendLine();

        sb.AppendLine("Daftar Karyawan Setelah Penghapusan:");
        sb.AppendLine(daftar.TampilkanDaftar());
        sb.AppendLine();

        sb.AppendLine("Mencari Karyawan dengan kata kunci 'IT':");
        Karyawan[] hasilCari = daftar.CariKaryawan("IT");
        foreach (var karyawan in hasilCari)
        {
            sb.AppendLine($"{karyawan.NomorKaryawan}; {karyawan.Nama}; {karyawan.Posisi}");
        }
        sb.AppendLine();

        return sb.ToString();
    }
}