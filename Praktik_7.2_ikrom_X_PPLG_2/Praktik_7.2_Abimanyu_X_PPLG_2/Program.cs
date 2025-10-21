using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7._2_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# hari ini");
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama anda: ");
            string namaSiswa = Console.ReadLine();
            SapaNama(namaSiswa); // Memanggil fungsi dengan argumen
        }
    }
}
