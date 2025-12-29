using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2PublivPrivateErisimBelirleyicileri
{
    public class Müsteri
    {
        public string isim;
        public string soyisim;

        public int maasDegeri;
        public string cinsiyet;

        private int yasDegeri;

        public Müsteri()
        {
            Console.WriteLine("Müşteri Sınıfının Yapıcı Metodu Çalıştı");
            
        }


        private void musteriBilgileriGoster()
    {
            Console.WriteLine("İsmi:" + isim);
            Console.WriteLine("Soyismi:" + soyisim);
            Console.WriteLine("Maaşı:" + maasDegeri);
            Console.WriteLine("Cinsiyeti:" + cinsiyet);
            Console.WriteLine("Yaşı:" + yasDegeri);
    }

    private void IsımSoyisimYazdir()
    {
            Console.WriteLine("İsim Soyisim:" + isim + " " + soyisim);

        } 
}
