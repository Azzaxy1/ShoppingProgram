using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pilih;
            int jumlah, total, bayar, tunai, kembali, diskon;


            Console.WriteLine("----------------------");
            Console.WriteLine(" PROGRAM PERBELANJAAN ");
            Console.WriteLine("----------------------");

            Console.WriteLine();
            Console.WriteLine(" PILIHAN PRODUK    : ");
            Console.WriteLine("A.Topi   : Rp. 7000 ");
            Console.WriteLine("B.Baju   : Rp. 35000");
            Console.WriteLine("C.Celana : Rp. 75000 ");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Masukan Pilihan Anda (A/B/C): ");

            pilih = Convert.ToString(Console.ReadLine());

            if (pilih == "A" || pilih == "a")
            {
                Console.WriteLine("Nama Barang    : Topi ");
                Console.Write("Jumlah Barang  : ");
                jumlah = Convert.ToInt32(Console.ReadLine());
                total = jumlah * 7000;
                Console.WriteLine("Harga Barang   : Rp. 7000 ");
                Console.WriteLine("Total Harga    : Rp. {0}", total);
                Console.Write("Bayar Tunai    : Rp. ");
                tunai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Besar Diskon   : 2% ");
                diskon = (total * 2) / 100;
                bayar = total - diskon;
                Console.WriteLine("Jumlah Bayar   : Rp. {0}", bayar);
                kembali = tunai - bayar;
                Console.WriteLine("Kembalian      : Rp. {0}", kembali);

            }
            else if (pilih == "B" || pilih == "b")
            {
                Console.WriteLine("Nama Barang    : Baju  ");
                Console.Write("Jumlah Barang  : ");
                jumlah = Convert.ToInt32(Console.ReadLine());
                total = jumlah * 35000;
                Console.WriteLine("Harga Barang   : Rp. 35000 ");
                Console.WriteLine("Total Harga    : Rp. {0}", total);
                Console.Write("Bayar Tunai    : Rp. ");
                tunai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Besar Diskon   : 2% ");
                diskon = (total * 2) / 100;
                bayar = total - diskon;
                Console.WriteLine("Jumlah Bayar   : Rp. {0}", bayar);
                kembali = tunai - bayar;
                Console.WriteLine("Kembalian      : Rp. {0}", kembali);
            }
            else if (pilih == "C" || pilih == "c")
            {
                Console.WriteLine("Nama Barang    : Celana ");
                Console.Write("Jumlah Barang  : ");
                jumlah = Convert.ToInt32(Console.ReadLine());
                total = jumlah * 75000;
                Console.WriteLine("Harga Barang   : Rp. 75000 ");
                Console.WriteLine("Total Harga    : Rp. {0}", total);
                Console.Write("Bayar Tunai    : Rp. ");
                tunai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Besar Diskon   : 2% ");
                diskon = (total * 2) / 100;
                bayar = total - diskon;
                Console.WriteLine("Jumlah Bayar   : Rp. {0}", bayar);
                kembali = tunai - bayar;
                Console.WriteLine("Kembalian      : Rp. {0}", kembali);
            }

            Console.ReadKey();
        }
    }
}
