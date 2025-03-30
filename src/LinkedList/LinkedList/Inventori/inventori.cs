namespace LinkedList.Inventori;

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

public class ItemNode
{
    public Item Data { get; }
    public ItemNode Next { get; set; }

    public ItemNode(Item item)
    {
        Data = item;
        Next = null;
    }
}

public class ManajemenInventori
{
    private ItemNode head;

    public void TambahItem(Item item)
    {
        ItemNode newNode = new ItemNode(item);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            ItemNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public bool HapusItem(string nama)
    {
        if (head == null) return false;

        if (head.Data.Nama == nama)
        {
            head = head.Next;
            return true;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.Data.Nama != nama)
        {
            temp = temp.Next;
        }

        if (temp.Next == null) return false;

        temp.Next = temp.Next.Next;
        return true;
    }

    public void TampilkanInventori()
    {
        ItemNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Data.Nama}; Kuantitas: {temp.Data.Kuantitas}");
            temp = temp.Next;
        }
    }
}

public class ManajemenInventoriApp
{
    public static void Run()
    {
        ManajemenInventori inventori = new ManajemenInventori();

        inventori.TambahItem(new Item("Laptop", 10));
        inventori.TambahItem(new Item("Mouse", 25));
        inventori.TambahItem(new Item("Keyboard", 15));

        Console.WriteLine("Inventori Awal:");
        inventori.TampilkanInventori();
        Console.WriteLine();

        Console.WriteLine("Menghapus 'Mouse'...");
        bool berhasil = inventori.HapusItem("Mouse");
        Console.WriteLine(berhasil ? "Item berhasil dihapus." : "Item tidak ditemukan.");
        Console.WriteLine();

        Console.WriteLine("Inventori Setelah Penghapusan:");
        inventori.TampilkanInventori();
        Console.WriteLine();
    }
}
