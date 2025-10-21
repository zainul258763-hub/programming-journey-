using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan nilai kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan nilai ketiga: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double hasil = rata_rata(a, b, c);
            Console.WriteLine($"\nRata-rata = {hasil}");

        }
        static double rata_rata(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}
