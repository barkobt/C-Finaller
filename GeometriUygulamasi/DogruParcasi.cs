using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriUygulamasi
{
    public class DogruParcasi
    {
        private Nokta A; // Baslangiç noktasi
        private Nokta B; // Bitis noktasi

        public DogruParcasi(Nokta n1, Nokta n2)
        {
            A = n1;
            B = n2;
        }

        public DogruParcasi(Nokta n1)
        {
            A = n1;
            B = new Nokta(); // Eger ikinci nokta verilmezse orijin (0,0) kabul et
        }

        // Iki nokta arasindaki uzaklik (Öklid Mesafesi)
        public double Uzunluk()
        {
            int xf = A.GetX() - B.GetX();
            int yf = A.GetY() - B.GetY();
            return Math.Sqrt(xf * xf + yf * yf);
        }

        // Egim hesaplama (y'deki degisim / x'deki degisim)
        public double Egim()
        {
            int xf = A.GetX() - B.GetX();
            int yf = A.GetY() - B.GetY();

            // Kritik Bilgi: Tam sayiyi (int) tam sayiya bölerseniz sonuç tam sayi çikar.
            // 1.0 ile çarparak sonucu double (ondalikli) yapiyoruz.
            if (xf == 0) return double.NaN; // Tanimsiz egim (dikey dogru)
            return 1.0 * yf / xf;
        }

        // Egimin Radyan cinsinden açisi
        public double EgimAciR()
        {
            return Math.Atan(Egim());
        }

        // Egimin Derece cinsinden açisi
        public double EgimAciD()
        {
            return 180 * EgimAciR() / Math.PI;
        }

        public override string ToString()
        {
            string str = $"A({A.GetX()},{A.GetY()}) --- B({B.GetX()},{B.GetY()})\n";
            str += $"Uzunluk: {Uzunluk():F2}\n";
            str += $"Açi (Radyan): {EgimAciR():F4}\n";
            str += $"Açi (Derece): {EgimAciD():F2}\n";
            str += "----------------------";
            return str;
        }
    }
}
