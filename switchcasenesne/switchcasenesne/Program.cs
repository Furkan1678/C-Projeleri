using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcasenesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arasinav+Final Universite not hesaplama ve geçtin kaldın hesaplama calismasi FK //
            Console.WriteLine("Lutfen arasinav notunuzu giriniz:");
            double arasinav = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lutfen Final notunuzu giriniz:");
            double final = Convert.ToDouble(Console.ReadLine());
            double ortalama = (arasinav * 40 / 100) + (final * 60 / 100);
            if (ortalama < 50)
            {
                ortalama = 0;
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                ortalama = 1;
            }
            else if (ortalama >= 60 && ortalama < 70)
            {
                ortalama = 2;
            }
            else if (ortalama >= 70 && ortalama < 80)
            {
                ortalama = 3;
            }
            else if (ortalama >= 80 && ortalama < 90)
            {
                ortalama = 4;
            }
            else if (ortalama >= 90 && ortalama < 101)
            {
                ortalama = 5;
            }
            switch (ortalama)
            {
                case 0: { Console.Write("FF"); break; }
                case 1: { Console.Write("CC"); break; }
                case 2: { Console.Write("CB"); break; }
                case 3: { Console.Write("BB"); break; }
                case 4: { Console.Write("BA"); break; }
                case 5: { Console.Write("AA"); break; }
                default: { Console.Write("Geçersiz not"); break; }

            }
            Console.ReadLine();
        }
    }
}
