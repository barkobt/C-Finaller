using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcdan aldığımız sayının karesini alalım eğer karesi 25'ten büyükse ekrana
            //  değilse "25'ten küçüktür" yazdıralım.
            // "25'ten büyüktür",

            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            SonucuYazdir(KareAl(sayi));
            Console.ReadLine(); 

        }

        static int KareAl(int sayi)
        {
            return sayi * sayi;
        }

        static void SonucuYazdir(int kare)
        {
            if (kare > 25)
            {
                Console.WriteLine("25'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("25'ten küçüktür.");
            }
        }

    }
}
