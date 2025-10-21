                 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7_kalkulator_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        // Method main adalah titik awal eksekusi program
        static void Main(string[] args)
        {
            string hitungLagi; // Variabel untuk menyimpan pemilihan pengguna (y/n)

            // Perulangan do-while akan menjalankan blok kode setidaknya satu kali
            // dan akan terus berjalan selama kondisi while terpenuhi.
            do
            {
                Console.Clear(); // Membesihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("---KALKULATOR SEDERHANA---");

                // Memanggil fungsi untuk menamoilkan menu
                TampilkanMenu();

                Console.Write("Masukkan pilihan operasi (1-4): ");
                string pilihan = Console.ReadLine();

                // Variabel untuk menampung hasil dan angka
                double angka1, angka2, hasil = 0;

                // Memanggil fungsi untuk mendapatkan input angka dari user
                // dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    // Struktur pemilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": // Penjumlahan
                            hasil = tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": // Pengurangan
                            hasil = kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // Perkalian
                            hasil = kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4": // Pembagian
                                  // Penanganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                            break;
                        default: // Jika pilihan tidak ada dicase 1-4
                            Console.WriteLine("\nPilihan yang anda masukkan tidak valid.");
                            break;
                    }
                }
                // Menanyakan kepada pengguna apakah ingin menghitung lagi
                Console.Write("\nApakah anda ingin menghitung kembali? (y/n)");
                hitungLagi = Console.ReadLine();
                // .ToLower() membuat input menjadi huruf kecil, jadi 'Y' atau 'y' akan sama
            }
            while (hitungLagi.ToLower() == "y");

            // pesan penutup jika pengguna memilih untuk keluar
            Console.WriteLine("\nTerimakasih telah mneggunakan kalkulator ini. " + "Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }

        // --- FUNGSI-FUNGSI BANTUAN ---

        // Fungsi untuk menampilkan menu pilihan

        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi matematika: ");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }

        // Fungsi untuk mengambil input angka dari pengguna
        // Menggunakan 'out' karena fungsi ini mengembalikan lebih dari satu nilai

        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("masukan angka pertama: ");
            // double.TryParse akan mencoba mengkonversi string ke double.
            // Jika berhasil, return true dan nilainya disimpan si variabel 'angka1'.
            // Jika gagal, return false.
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0; // Beri nilai default agar tidak error
                return false;
            }

            Console.Write("Masukan angka kedua: "); 
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid. ");
                return false;
            }

            return true; // Jika kedua imput valid
        }

        // Fungsi untuk operasi penjumlahan
        static double tambah(double a , double b)
        {
            return a + b;
        }

        // fungsi untuk opreasi pengurangan
        static double kurang(double a , double b)
        {
            return a - b;
        }

        // fungsi untuk opreasi perkalian
        static double kali(double a, double b)
        {
            return a * b;
        }
        
        // fungsi untuk opreasi pembagian
        static double bagi(double a, double b)
        {
            return a / b;
        }
    }
}
