using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 20, 30, 20, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            int count = 0;
            int sayi;

            Console.WriteLine("Lütfen bir sayı giriniz:");

            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == sayi)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Girilen sayı dizide bulunmamaktadır.");
            } else
            {
                Console.WriteLine("Girilen sayı dizide {0} kez geçmektedir.", count);
            }
        }
    }
}
