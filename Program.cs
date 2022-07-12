using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

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

            //Penjualan pjl = new Penjualan(nota, tanggal, customer, jenis, totalNota);

            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota : "); string nota = Console.ReadLine();
            Console.Write("Tanggal : "); string tanggal = Console.ReadLine();
            Console.Write("Customer : "); string customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : "); string jenis = Console.ReadLine();
            Console.Write("Total Nota : "); int totalNota = Convert.ToInt32(Console.ReadLine());

            Penjualan pjl = new Penjualan(nota, tanggal, customer, jenis, totalNota);

            daftarPenjualan.Add(pjl);

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            int i = 1;

            Console.WriteLine("Data Penjualan");

            foreach (Penjualan pnj in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", i, pnj.Nota, pnj.Tanggal, pnj.Customer, pnj.Jenis, pnj.TotalNota);
                i++;
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
