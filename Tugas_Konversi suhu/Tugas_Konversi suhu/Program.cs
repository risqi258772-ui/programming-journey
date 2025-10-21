using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Konversi_suhu
{
    internal class Program
    {
        // Fungsi KonversiSuhu : mengubah suhu dari Celcius dari Fahrenhiet
        static double konversisuhu(double c)
        {
            double f = (c * 9 / 5) + 32;
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== program KonversiSuhu Celcius ke Fahrenheit ===");

            // Input dari pengguna
            Console.Write("Masukkan suhu dalam Celcius: ");
            double suhuC = Convert.ToDouble(Console.ReadLine());

            //Panggil fungsi KonversiSuhu
            double suhuF = konversisuhu(suhuC);

            //Tampilkan Hasil Konversi
            Console.WriteLine($"{suhuC}℃ sama dengan {suhuF}℉");

            Console.WriteLine("=== program selesai ===");
        }
    }
}
