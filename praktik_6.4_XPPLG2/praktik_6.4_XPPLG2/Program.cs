using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._4_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Inisialisasi variabel penghitung(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur:");
            //2. Perulangan 'while'
            // Kondisi: Selama nilai 'hitungan' lebih besar dari 0
            while (hitungan > 0)
            {
                //Blok kode di dalam perulangan
                Console.WriteLine($"Hitung: {hitung}");

                //3. Update variabel penghitung (decrement/pengurangan)
                //Ini PENTING agar perulangan tidak menjadi loop tak terbatas (infinite loop)
                hitung = hitung - 1;
                // atau bisa juga ditulis hitungan--;
            }
            // Kode setelah perulangan selesai
            Console.WriteLine("Selesai1 Hitungan mundur telah berakhir.");
        }
    }
}
