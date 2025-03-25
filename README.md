[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/DLGhUAZh)
# Data Structure - Linked List

## Capaian Pembelajaran

1. Mahasiswa mampu mengimplementasikan struktur data single linked list dan double linked list.
2. Mahasiswa mampu menggunakan struktur data linked list buatan sendiri untuk studi kasus tertentu.
3. Mahasiswa mampu menggunakan struktur data LinkedList<> bawaan framework .NET untuk studi kasus tertentu.

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `ds-linked-list` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

### Soal: Perpustakaan

Buat solusi dari soal ini di project `LinkedList` folder `Perpustakaan` dengan namespace `LinkedList.Perpustakaan`.

Anda ditugaskan untuk membuat sistem manajemen buku perpustakaan sederhana menggunakan Linked List di C#. Sistem ini harus memungkinkan pengguna untuk menambahkan buku baru ke koleksi, menghapus buku dari koleksi berdasarkan judul, dan menampilkan daftar buku yang tersedia di perpustakaan. Setiap buku akan memiliki judul, penulis, dan tahun terbit sebagai informasi yang disimpan.

Langkah-langkah:

1. Buat kelas publik `Buku` yang memiliki tiga properti publik: `Judul` (string), `Penulis` (string), dan `Tahun` (int). Kelas ini akan merepresentasikan setiap buku dalam koleksi perpustakaan. Buat metode konstruktor yang menginisialisasi ketiga properti tersebut.

2. Buat kelas publik `BukuNode` untuk menyimpan objek `Buku`. Kelas `BukuNode` memiliki properti publik `Buku` dan `Next`. Buat metode konstruktor yang menginisialisasi properti `Buku`.

3. Buat kelas publik `KoleksiPerpustakaan` yang akan mengelola buku menggunakan struktur data Linked List.

4. Buat metode `TambahBuku` yang menerima input parameter buku bertipe `Buku` untuk menambahkan buku ke koleksi perpustakaan.

5. Buat metode `HapusBuku` yang menerima input parameter `judul` (string) dan mengembalikan nilai bertipe bool untuk menghapus buku dari koleksi perpustakaan berdasarkan judul buku. Metode ini mengembalikan nilai true jika berhasil melakukan penghapusan dan mengembalikan nilai false jika gagal atau tidak melakukan penghapusan.

6. Buat metode `CariBuku` yang menerima input parameter `kataKunci` (string) dan mengembalikan nilai bertipe `Buku[]`. Jika  `judul` buku mengandung `kataKunci` maka akan masuk di kembalian `Buku[]`. (Petunjuk: Gunakan metode `Contains()` yang ada di kelas String untuk mencari kandungan string)

6. Buat metode `TampilkanKoleksi` untuk menampilkan semua buku dalam koleksi, dengan setiap baris menunjukkan judul buku, penulis, dan tahun terbit. Format string yang harus diikuti adalah sebagai berikut:

```
"The Hobbit"; J.R.R. Tolkien; 1937
"1984"; George Orwell; 1949
"The Catcher in the Rye"; J.D. Salinger; 1951
```

7. Buat kelas publik `Program` di namespace `LinkedList` yang berisi metode `Main` untuk membuat beberapa buku dan memasukkannya ke koleksi perpustakaan.

### Soal: Manajemen Karyawan dengan Double Linked List

Buat solusi dari soal ini di project `LinkedList` dalam folder `ManajemenKaryawan` dengan namespace `LinkedList.ManajemenKaryawan`.

Anda diminta untuk membuat sistem manajemen karyawan sederhana menggunakan Double Linked List di C#. Sistem ini harus memungkinkan pengguna untuk menambahkan karyawan baru ke dalam daftar, menghapus karyawan dari daftar berdasarkan nomor karyawan, dan menampilkan daftar karyawan yang tersedia di perusahaan. Setiap karyawan akan memiliki nomor karyawan (unik), nama, dan posisi sebagai informasi yang disimpan.

Langkah-langkah:

1. Buat kelas publik `Karyawan` yang memiliki tiga properti publik: `NomorKaryawan` (string), `Nama` (string), dan `Posisi` (string). Kelas ini akan merepresentasikan setiap karyawan dalam perusahaan. Buat metode konstruktor yang menginisialisasi ketiga properti tersebut.

2. Buat kelas publik `KaryawanNode` untuk menyimpan objek `Karyawan`. Kelas `KaryawanNode` memiliki properti publik `Karyawan`, `Next`, dan `Prev`. Buat metode konstruktor yang menginisialisasi properti `Karyawan`.

3. Buat kelas publik `DaftarKaryawan` yang akan mengelola karyawan menggunakan struktur data Double Linked List.

4. Buat metode `TambahKaryawan` yang menerima input parameter karyawan bertipe `Karyawan` untuk menambahkan karyawan ke dalam daftar.

5. Buat metode `HapusKaryawan` yang menerima input parameter `nomorKaryawan` (string) dan mengembalikan nilai bertipe bool untuk menghapus karyawan dari daftar berdasarkan nomor karyawan. Metode ini mengembalikan nilai true jika berhasil melakukan penghapusan dan mengembalikan nilai false jika gagal atau tidak melakukan penghapusan.

6. Buat metode `CariKaryawan` yang menerima input parameter `kataKunci` (string) dan mengembalikan nilai bertipe `Karyawan[]`. Jika `nama` atau `posisi` karyawan mengandung `kataKunci` maka akan masuk di kembalian `Karyawan[]`.

7. Buat metode `TampilkanDaftar` untuk menampilkan semua karyawan dalam daftar secara terbalik dari urutan penambahan, dengan setiap baris menunjukkan nomor karyawan, nama, dan posisi. Format string yang harus diikuti adalah sebagai berikut:

Urutan penambahan:
```
001; John Doe; Manager
002; Jane Doe; HR
003; Bob Smith; IT
```

Urutan tampilan:
```
003; Bob Smith; IT
002; Jane Doe; HR
001; John Doe; Manager
```

8. Buat kelas publik `Program` di namespace `LinkedList` yang berisi metode `Main` untuk membuat beberapa karyawan dan memasukkannya ke dalam daftar.

### Soal: Sistem Manajemen Inventori dengan LinkedList .NET

Buat solusi dari soal ini di project `LinkedList` dalam folder `Inventori` dengan namespace `LinkedList.Inventori`. 

Anda diminta untuk membuat sistem manajemen inventori sederhana menggunakan `LinkedList<T>` dari .NET Framework di C#. Sistem ini harus memungkinkan pengguna untuk menambahkan item baru ke dalam inventori, menghapus item dari inventori berdasarkan nama, dan menampilkan daftar item yang tersedia. Setiap item akan memiliki nama dan kuantitas sebagai informasi yang disimpan.

Langkah-langkah:

1. **Buat kelas publik `Item`** yang memiliki dua properti publik: `Nama` (string) dan `Kuantitas` (int). Kelas ini akan merepresentasikan setiap item dalam inventori. Buat metode konstruktor yang menginisialisasi kedua properti tersebut.

2. **Buat kelas publik `ManajemenInventori`** yang akan mengelola item menggunakan struktur data `LinkedList<Item>`.

3. **Buat metode `TambahItem`** yang menerima input parameter item bertipe `Item` untuk menambahkan item ke dalam inventori.

4. **Buat metode `HapusItem`** yang menerima input parameter `nama` (string) dan mengembalikan nilai bertipe bool untuk menghapus item dari inventori berdasarkan nama item. Metode ini mengembalikan nilai true jika berhasil melakukan penghapusan dan mengembalikan nilai false jika gagal atau tidak melakukan penghapusan.

5. **Buat metode `TampilkanInventori`** untuk menampilkan semua item dalam inventori, dengan setiap baris menunjukkan nama item dan kuantitasnya. Format string yang harus diikuti adalah sebagai berikut:

```
Nama Item; Kuantitas
Apple; 50
Orange; 30
Banana; 20
```

6. **Buat kelas publik `Program`** yang berisi metode `Main` di namespace `LinkedList` untuk membuat beberapa item dan memasukkannya ke dalam inventori.
