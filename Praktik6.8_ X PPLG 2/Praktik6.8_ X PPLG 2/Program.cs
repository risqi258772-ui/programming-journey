using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._8__X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- Blok Proses yang Akan Diulang ---
                Console.WriteLine("-----------------------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama} ! Proses telas selesai.");
                //--------------------------------------
                //Pertanyaan untuk Mengulang
                Console.Write("Apakah anda ingin mengulang lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris Kosong Untuk Kerapian

                //Kondisi diperiksa di akhir: Ulangi selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");
              Console.WriteLine("Terima kasih.Program selesai.");
        }
    }
}
