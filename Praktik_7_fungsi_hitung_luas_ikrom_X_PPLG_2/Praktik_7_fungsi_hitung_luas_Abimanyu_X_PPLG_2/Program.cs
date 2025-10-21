using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7_fungsi_hitung_luas_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static double HitungLuas(double panjang, double lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }

        static void Main(string[] args)
        {
            Console.Write("Masukkan panjang :");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Masukkan lebar :");
            double l = Convert.ToDouble(Console.ReadLine());

            double hasil = HitungLuas(p,l);
            Console.WriteLine("Luas persegi panjang adalah: " + hasil);
        }
    }
}
