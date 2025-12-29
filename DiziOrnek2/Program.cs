using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kullanıcıdan 10 tane int değer alan ve şunları yapan programı kodlayınız...
             1- Kaç adet tek, çift sayı girildiğini bulunuz.
             2- Çift sayıların toplamını, tek sayıların toplamını bulunuz.
             3- Girilen sayılar arasında en büyük ve en küçük sayıyı bulunuz.
             4- Girilen sayıları küçükten büyüğe sıralayınız ve ekrana yazdırınız.
             5- Girilen sayılardan pozitif olanların ortalamasını bulunuz.
             6- Son olarak kontrol yapsin çift değerlerin toplamı tek değerlerden büyük ise çift değerlerin toplamı büyüktür, 
                tek değerlerin toplamı çift değerlerden büyük ise tek değerlerin toplamı büyüktür, 
                eşit ise çift ve tek değerlerin toplamı eşittir ekrana yazdırınız.
             */

            int[] sayilar = new int[10];
            Console.WriteLine("10 adet sayı giriniz: ");
            for(int i =0; i<sayilar.Length; i++){
                Console.WriteLine($"{i+1}. sayıyı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int cift_toplam = 0, tek_toplam = 0;
            int cift_sayi_adet = 0, tek_sayi_adet = 0;

            for (int i = 0; i<sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0) { 
                    cift_toplam += sayilar[i];
                    cift_sayi_adet++;
                }
                else { 
                    tek_toplam += sayilar[i];
                    tek_sayi_adet++;
                }
            }
            Console.WriteLine($"Girilen çift sayıların adeti: {cift_sayi_adet}\nGirilen çift sayıların toplamı: {cift_toplam}");
            Console.WriteLine($"Girilen tek sayıların adeti: {tek_sayi_adet}\nGirilen tek sayıların toplamı: {tek_toplam}");

            int en_buyuk = sayilar[0];
            int en_kucuk = sayilar[0];

            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > en_buyuk)
                    en_buyuk = sayilar[i];
                if (sayilar[i] < en_kucuk)
                    en_kucuk = sayilar[i];
            }
            Console.WriteLine($"Girilen sayılar arasında en büyük sayı: {en_buyuk}\nGirilen sayılar arasında en küçük sayı: {en_kucuk}");

            Array.Sort(sayilar);
            Console.WriteLine("Girilen sayılar küçükten büyüğe sıralanmış hali:");
            foreach (var sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            double pozitif_toplam = 0;
            int pozitif_adet = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > 0)
                {
                    pozitif_toplam += sayilar[i];
                    pozitif_adet++;
                }
            }
            double pozitif_ortalama = pozitif_adet > 0 ? pozitif_toplam / pozitif_adet : 0;

            Console.WriteLine($"Girilen pozitif sayıların ortalaması: {pozitif_ortalama}");
            if (cift_toplam > tek_toplam)
            {
                Console.WriteLine("Çift değerlerin toplamı tek değerlerden büyüktür.");
            }
            else if (tek_toplam > cift_toplam)
            {
                Console.WriteLine("Tek değerlerin toplamı çift değerlerden büyüktür.");
            }
            else
            {
                Console.WriteLine("Çift ve tek değerlerin toplamı eşittir.");
            }


        }
    }
}
