using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            // Beden Kitle Endeksi Hesaplama = Kilo/ boy*boy
            // Beden Kitle Endeksi 18.5'un altındaysa: Zayıf
            // Beden Kitle Endeksi 18.5-24.9 arasındaysa: Normal
            // Beden Kitle Endeksi 25-29.9 arasındaysa: Fazla Kilolu
            Console.WriteLine("Lütfen kilonuzu kg cinsinden giriniz:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bedenKitleEndeksi = kilo / (boy * boy );
            Console.WriteLine("Beden Kitle Endeksiniz: " + bedenKitleEndeksi);

            if (bedenKitleEndeksi < 18.5)
            {
                Console.WriteLine("Durumunuz: Zayıf");
                Console.ReadLine();
            }
            else if (bedenKitleEndeksi >= 18.5 && bedenKitleEndeksi <= 24.9)
            {
                Console.WriteLine("Durumunuz: Normal");
                Console.ReadLine();
            }
            else if (bedenKitleEndeksi >= 25 && bedenKitleEndeksi <= 29.9)
            {
                Console.WriteLine("Durumunuz: Fazla Kilolu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Durumunuz: Obez");
 
                Console.ReadLine();
            }

        }
    }
}
