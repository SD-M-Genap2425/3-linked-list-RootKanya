namespace LinkedList.Inventori;

using System;
using System.Collections.Generic;
using System.Text;

public class Item
{
    public string Nama { get; }
    public int Kuantitas { get; set; }

    public Item(string nama, int kuantitas)
    {
        Nama = nama;
        Kuantitas = kuantitas;
    }
}

public class ManajemenInventori
{
    private LinkedList<Item> inventori = new LinkedList<Item>();

    public void TambahItem(Item item)
    {
        inventori.AddLast(item);
    }

    public bool HapusItem(string nama)
    {
        var node = inventori.First;
        while (node != null)
        {
            if (node.Value.Nama == nama)
            {
                inventori.Remove(node);
                return true;
            }
            node = node.Next;
        }
        return false;
    }

    public string TampilkanInventori()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in inventori)
        {
            sb.AppendLine($"{item.Nama}; {item.Kuantitas}");
        }
        return sb.ToString().TrimEnd();
    }

    public static string Run() 
    {
        StringBuilder sb = new StringBuilder();
        ManajemenInventori inventori = new ManajemenInventori();

        inventori.TambahItem(new Item("Laptop", 10));
        inventori.TambahItem(new Item("Mouse", 25));
        inventori.TambahItem(new Item("Keyboard", 15));

        sb.AppendLine("Inventori Awal:");
        sb.AppendLine(inventori.TampilkanInventori());
        sb.AppendLine();

        sb.AppendLine("Menghapus 'Mouse'...");
        bool berhasil = inventori.HapusItem("Mouse");
        sb.AppendLine(berhasil ? "Item berhasil dihapus." : "Item tidak ditemukan.");
        sb.AppendLine();

        sb.AppendLine("Inventori Setelah Penghapusan:");
        sb.AppendLine(inventori.TampilkanInventori());
        sb.AppendLine();

        return sb.ToString();
    }
}
