using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometriUygulamasi
{
    public class Nokta // Görsellerdeki 'nokta' sınıfı
    {
        // Private alanlar (Encapsulation - Kapsülleme gereği dışarıdan doğrudan erişilemez)
        private int x;
        private int y;

        // Properties (Özellikler): Veriyi kontrollü bir şekilde dışarı açarız.
        public int FX
        {
            get { return x; }
            set
            {
                // İş mantığı: Eğer değer 20'den büyükse 20'ye sabitle (Görseldeki mantık)
                if (value > 20) x = 20;
                else x = value;
            }
        }

        public int FY
        {
            get { return y; }
            set
            {
                if (value > 20) y = 20;
                else y = value;
            }
        }

        // Yapıcı Metotlar (Constructors): Nesne üretilirken ilk çalışan metot.
        public Nokta(int x1, int y1)
        {
            // Burada doğrudan set bloklarını tetiklemek için Property'leri kullanmak daha güvenlidir
            FX = x1;
            FY = y1;
        }

        public Nokta() // Parametresiz yapıcı: Varsayılan (0,0) noktası oluşturur.
        {
            x = 0;
            y = 0;
        }

        // Metotlar
        public int GetX() => x;
        public int GetY() => y;

        // Orijine olan uzaklığı hesaplar: Karekök(x^2 + y^2)
        public double Uzaklik()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // Nesne yazdırıldığında nasıl görüneceğini belirler (Override)
        public override string ToString()
        {
            string str = $"Nokta({x}, {y})\n";
            str += $"Orijine Uzaklık: {Uzaklik():F2}\n"; // F2: Virgülden sonra 2 basamak
            str += "----------------------";
            return str;
        }
    }
}
