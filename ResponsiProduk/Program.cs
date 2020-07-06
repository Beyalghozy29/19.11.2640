
using ResponsiProduk2640;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiProduk2640
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> Produknya = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS ";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("=====================");
            Console.WriteLine(" 1. Tambah Produk.\n 2. Hapus Produk.\n 3. Tampilkan Produk.\n 4. Keluar. ");
            Console.WriteLine("=====================");
        }

        static void TambahProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Produk produkk = new Produk();
            Console.WriteLine("KODE PRODUK  :");
            produkk.KODE = Console.ReadLine();
            Console.WriteLine("NAMA PRODUK  :");
            produkk.NAMA = Console.ReadLine();
            Console.WriteLine("HARGA BELI  :");
            produkk.HARGABELI = Console.ReadLine();
            Console.WriteLine("HARGA JUAL  :");
            produkk.HARGAJUAL = Console.ReadLine();
            Console.WriteLine();
            Produknya.Add(produkk);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            
            Console.ReadKey();
        }

        static void HapusProduk()
        {

            Console.Clear();
            string rem;
            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            onsole.WriteLine("===============");
            Console.WriteLine("Hapus Produk");
            Console.WriteLine();
            Console.WriteLine("===============");
            Console.Write(" Kode Produk    :")
            Console.WriteLine("===============");
            rem = Console.ReadLine();
            var del = Produknya.SingleOrDefault(f => f.KODE == rem);
            if (del == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Kode Produk Tidak Ada");
                
                } else
                        {
                            Produknya.Remove(del);
                            Console.WriteLine("Data Produk Di Hapus");
                        }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            int x = 1;
            Console.WriteLine("Data Produk");
            Console.WriteLine("===============");
            Console.WriteLine();

            foreach (Produk produkk in Produknya)
                 {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", x, produkk.KODE, produkk.NAMA, produkk.HARGABELI, produkk.HARGAJUAL);
                x++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");

            Console.ReadKey();
        }
    }
}
