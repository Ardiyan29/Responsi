using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.Write("Pilih Menu Aplikasi\n");
            Console.Write("\n1. Tambah Penjualan\n");
            Console.Write("2. Tampilkan Penjualan\n");
            Console.Write("3. Keluar\n");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            Penjualan pjl = new Penjualan();

            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota : "); pjl.Nota = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tanggal : "); pjl.Tanggal = Console.ReadLine();
            Console.Write("Customer : "); pjl.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : "); pjl.Jenis = Console.ReadLine();
            Console.Write("Total Nota : "); pjl.Total = Convert.ToInt32(Console.ReadLine());

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
