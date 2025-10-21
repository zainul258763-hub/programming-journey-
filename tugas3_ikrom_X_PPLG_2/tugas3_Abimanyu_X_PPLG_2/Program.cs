using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3_Abimanyu_X_PPLG_2
{
    internal class Program
    {   
        /* Buat fungsikonversi untuk mengubah suhu dari celcius ke fahrenheit dengan rumus:
         F = (C × 9/5) + 32.
        Tampilkan hasil konversi pada program utama! */

        static double ConvertCelciusToFahrenheit(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program konversi suhu dari celcius ke fahrenheit");
            Console.Write("Masukan suhu dalam celcius:  ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{celsius}°C= {fahrenheit}");
        }
    }
}
