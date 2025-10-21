using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_fungsi_kali
{
    internal class Program
    {
        static double Kali(double x, double y, double z)
        {
            return x + y + z; 
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            double bil1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double bil2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka ketiga: ");
            double bil3 = Convert.ToDouble(Console.ReadLine());

            double hasil = Kali(bil1, bil2, bil3);

            Console.WriteLine($"\nHasul dari {bil1} * {bil2} * {bil3} = {hasil}");
        }
    }
}
