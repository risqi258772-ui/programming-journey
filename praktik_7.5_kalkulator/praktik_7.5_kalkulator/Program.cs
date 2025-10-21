using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_7._5_kalkulator
{
    internal class Program
    {
        //Method main adalah titik awal eksekusi program

        static void Main(string[] args)
        {
            string hitungLagi; // Variabel untuk menyimpan pilihan pengguna (y/n)

            //Mamanggilkan do-while akan mmenjalankan blok kode setidaknya satu kali
            //dan akan terus berjalan selama kondisi while terpenuhi.
            do
            {
                Console.Clear(); // Membersihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("---KALKULATOR SEDERHANA---");

                //memanggilkan fungsi untuk menampilkan menu
                TampilkanMenu();

                Console.Write("Masukkan pilihan operasi (1-4): ");
                string pilihan = Console.ReadLine();

                //Variabel untuk menampung angka dan hasil
                double angka1, angka2, hasil = 0;

                //Memanggilkan fungsi untuk mendapatkan input angka dari user
                //dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    //Struktur pilihan switch-case untuk menentukan operasi 
                    switch (pilihan)
                    {
                        case "1": // Penjumlahan
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil : {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": //pengurangan 
                            hasil = Kurang(angka1,angka2);
                            Console.WriteLine($"\nHasil : {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // Perkalian 
                            hasil = kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                                break;
                        case "4": // Pembagian 
                            //Penanganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                                break;
                        default: // Jika pilihan tidak ada di case 1-4
                            Console.WriteLine("\nPilihan yang Anda masukkan tidak valid.");
                        break;
                        }
                            
                    }

                //Menanyakan kepada pengguna apakah ingin menghitung lagi
                Console.Write("\nApakah Anda ingin menghiitung kembali? (y/n): ");
                hitungLagi = Console.ReadLine();
                // .ToLower() membuat input menjadi huruf kecil, jadi 'Y' atau 'y' akan sama


            } while (hitungLagi.ToLower() == "y");

            // Pesan Penutup jika pengguna memilih untuk keluar 
            Console.WriteLine("\nTerima Kasih telah menggunakan kalkulator ini. " +
                                "Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
            //--- FUNGSI-FUNGSI BANTUAN ---



        }
        // Fungsi untuk menampilkan menu pilihan 

        static void TampilkanMenu()
        {
            Console.WriteLine("pilih operasi matematika:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        // Fungsi untuk mengambil input angka dari penggura
        // Menggunakan 'out' karena fungsi ini mengambilkan lebih dari satu nilai 

        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            //double.TryParse akan mencoba mengkonversi string ke double.
            //Jika berhasil, return true dan nilainya disimpan di variabel 'angka1'.
            //jika gagal, return false.
            if (!double.TryParse(Console.ReadLine(), out angka1))
                        {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0; // Beri nilai defaul agar tidak error
                return false;
            }
            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                return false;
            }
            return true; //Jika kedua input valid
        }
        //fungsi untuk operasi penjumlahan 

        static double Tambah(double a, double b)
        {
            return a + b;
        }
        //Fungsi untuk operasi pengurangan
        static double Kurang(double a, double b)
        {
            return a - b;
        }
        // Fungsi untuk operasi perkalian
        static double Bagi(double a, double b)
        {
            return a / b;
        }
        // Fungsi untuk operasi perkalian
        static double kali(double a, double b)
        {
            return a * b;
        }
    }
}
