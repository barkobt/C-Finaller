using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2PublivPrivateErisimBelirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public--private erişim belirleyicileri

        Müsteri musteri1 = new Müsteri();
        musteri1.isim = "Ahmet";
        musteri1.soyisim = "Yılmaz";
        musteri1.maasDegeri = 5000;
        musteri1.cinsiyet = "Erkek";

        musteri1.yas = 22; // Hata: 'Müsteri.yasDegeri' erişim belirleyicisi 'private' olduğu için erişilemez.
        musteri1.musteriBilgileriGoster(); // Metot hata verir çünkü private
        // Yalnızca public üyelere erişilebilir.
        // Yalnızca Müşteri sınıfı içinden erişilebilir.

        }
    }
}
