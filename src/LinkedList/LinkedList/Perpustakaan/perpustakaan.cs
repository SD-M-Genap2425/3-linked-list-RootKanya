namespace LinkedList.Perpustakaan;

public class Buku
{
    public string Judul { get; }
    public string Penulis { get; }
    public int Tahun { get; }

    public Buku(string judul, string penulis, int tahun)
    {
        Judul = judul;
        Penulis = penulis;
        Tahun = tahun;
    }
}

public class BukuNode
{
    public Buku Data { get; }
    public BukuNode Next { get; set; }

    public BukuNode(Buku buku)
    {
        Data = buku;
        Next = null;
    }
}

public class KoleksiPerpustakaan
{
    private BukuNode head;

    public void TambahBuku(Buku buku)
    {
        BukuNode newNode = new BukuNode(buku);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            BukuNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public bool HapusBuku(string judul)
    {
        if (head == null) return false;

        if (head.Data.Judul == judul)
        {
            head = head.Next;
            return true;
        }

        BukuNode temp = head;
        while (temp.Next != null && temp.Next.Data.Judul != judul)
        {
            temp = temp.Next;
        }

        if (temp.Next == null) return false;

        temp.Next = temp.Next.Next;
        return true;
    }

    public Buku[] CariBuku(string kataKunci)
    {
        List<Buku> hasil = new List<Buku>();
        BukuNode temp = head;
        while (temp != null)
        {
            if (temp.Data.Judul.Contains(kataKunci))
            {
                hasil.Add(temp.Data);
            }
            temp = temp.Next;
        }
        return hasil.ToArray();
    }

    public void TampilkanKoleksi()
    {
        BukuNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"\"{temp.Data.Judul}\"; {temp.Data.Penulis}; {temp.Data.Tahun}");
            temp = temp.Next;
        }
    }
}

public class PerpustakaanApp
{
    public static void Run()
    {
        KoleksiPerpustakaan perpustakaan = new KoleksiPerpustakaan();

        perpustakaan.TambahBuku(new Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        perpustakaan.TambahBuku(new Buku("1984", "George Orwell", 1949));
        perpustakaan.TambahBuku(new Buku("The Catcher in the Rye", "J.D. Salinger", 1951));
        perpustakaan.TambahBuku(new Buku("Harry Potter", "J.K. Rowling", 1997));

        Console.WriteLine("Koleksi Awal:");
        perpustakaan.TampilkanKoleksi();
        Console.WriteLine();

        Console.WriteLine("Menghapus '1984'...");
        bool berhasil = perpustakaan.HapusBuku("1984");
        Console.WriteLine(berhasil ? "Buku berhasil dihapus." : "Buku tidak ditemukan.");
        Console.WriteLine();

        Console.WriteLine("Koleksi Setelah Penghapusan:");
        perpustakaan.TampilkanKoleksi();
        Console.WriteLine();

        Console.WriteLine("Mencari Buku dengan kata kunci 'Harry':");
        Buku[] hasilCari = perpustakaan.CariBuku("Harry");
        foreach (var buku in hasilCari)
        {
            Console.WriteLine($"\"{buku.Judul}\"; {buku.Penulis}; {buku.Tahun}");
        }
        Console.WriteLine();
    }
}
