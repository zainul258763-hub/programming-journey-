using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1_Abimanyu_X_PPLG_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka ketiga: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double hasil = kali(a, b, c);
            Console.WriteLine($"\n{a} * {b} * {c} = {hasil}");
        }
        static double kali(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
