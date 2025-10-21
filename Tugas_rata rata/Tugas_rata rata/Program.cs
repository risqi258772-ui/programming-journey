using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_rata_rata
{
    internal class Program
    {
        static double HitungRataRata(double nilai1, double nilai2, double nilai3)
        {
            double hasil = (nilai1 + nilai2 + nilai3) / 3;
            return hasil;
        }
        static void Main(string[] args)
        {
            // Meminta input dari pengguna
            Console.Write("Masukkan nilai pertama: ");
            double nilai1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai kedua: ");
            double nilai2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga: ");
            double nilai3 = Convert.ToDouble(Console.ReadLine());

            //Memanggil fungsi dan menampilkan hasilnya
            double hasil = HitungRataRata(nilai1, nilai2, nilai3);

        }

    }
}
