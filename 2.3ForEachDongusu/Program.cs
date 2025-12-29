using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Foreach döngüsü ile dizi elemanlarını ekrana yazdırma

            string[] isimler = { "Enes", "Yasin", "Mehmet" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            //foreach döngüsü
            Console.WriteLine("Foreach döngüsü ile isimler:");
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            double [] ondalikli_sayilar = { 10.5, 20.3, 30.6, 40.2 };
            Console.WriteLine("Foreach döngüsü ile ondalıklı sayılar:");
            foreach (double sayi in ondalikli_sayilar)
            {
                Console.WriteLine(sayi);
            }

            
        }
    }
}
