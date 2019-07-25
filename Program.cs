using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

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
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Produk pdk = new Produk();
            // TODO: tuliskan logika Anda di sini ...
            Console.Write("Kode Produk: ");
            pdk.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk: ");
            pdk.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli: ");
            pdk.HargaBeli = Console.ReadLine();
            Console.Write("Harga Jual: ");
            pdk.HargaJual = Console.ReadLine();
            Console.WriteLine();
            daftarProduk.Add(pdk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Produk pdk = new Produk();

            Console.Clear();
            string cek;
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Hapus Produk");
            Console.WriteLine();
            Console.Write("Kode Produk: ");
            cek = Console.ReadLine();
            var hapus = daftarProduk.SingleOrDefault(f => f.KodeProduk == cek);
            if (hapus == null)
            {
                Console.WriteLine();
                Console.WriteLine("Kode Produk tidak ditemukan");
            }
            else 
            {
             daftarProduk.Remove(hapus);
             Console.WriteLine("Data Produk berhasil dihapus");
                
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int i = 1;
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Produk");
            Console.WriteLine();
            foreach (Produk pdk in daftarProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", i, pdk.KodeProduk, pdk.NamaProduk, pdk.HargaBeli, pdk.HargaJual);
                i++;
            }
            
            Console.WriteLine("\nTekan enter untuk kembali ke menu");

            Console.ReadKey();
        }
    }
}
