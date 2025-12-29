using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;
            //Kullancııya soracağız nasıl bir işlem yapmak istediğini
            // 1- Bakiye Görüntüleme
            // 2- Para Çekme
            // 3- Para Yatırma
            // q ya basarsa çıkış yaptıracağız.

            Console.WriteLine("ATM'ye hoşgeldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");

            String secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz: " + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediginiz tutarı giriniz:");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)
                {
                    string value = $"Kalan Tutar: {(bakiye - cekilecek_tutar)}";
                    Console.WriteLine(value);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    Console.ReadLine();
                }

            }
            else if (secim == "3") 
            {
                Console.WriteLine("Yatırmak istediginiz tutarı giriniz:");
                int yatirilacak_tutar = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine("Yeni bakiyeniz: " + (bakiye + yatirilacak_tutar));
                Console.ReadLine();
            }
            else if (secim == "4")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı iyi günler...");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Geçersiz işlem seçtiniz lütfen tekrar deneyiniz.");
            }
        }
    }
}
