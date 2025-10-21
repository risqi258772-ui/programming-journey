using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._3_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variabel untuk menyimoan input
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalanhingga anda mengetik 'keluar'.");

            // Perulangan selama isi variabel inputUser TIDAK SMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); //  Baca input dari user

                Console.WriteLine("Anda mengetik: " + inputUser);
            }
            Console.WriteLine("\nProgram selesai. Terima kasih!");
        }
    }
}
