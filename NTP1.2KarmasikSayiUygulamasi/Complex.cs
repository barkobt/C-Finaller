using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmasikSayiUygulamasi
{
    internal class Complex
    {
        private double reel;
        private double sanal;

        //Yapıcı Metotlar
        public Complex(double r, double s)
        {
            this.reel = r;
            this.sanal = s; // this anahtar kelimesi ile sınıfın kendi alanlarına erişiyoruz
        }

        public Complex(double r)
        {
            this.reel = r;
            this.sanal = 0;
        }

        //Metotlar
        // Karmaşık sayının modülünü hesaplar

        public Complex Eslenik() => new Complex(reel, -sanal);
        public double Norm() => Math.Sqrt(reel * reel + sanal * sanal);
        public double Modulus()
        {
            return Math.Sqrt(reel * reel + sanal * sanal);
        }

        // Static Toplama Metodu
        public static Complex Topla(Complex c1, Complex c2)
        {
            return new Complex(c1.reel + c2.reel, c1.sanal + c2.sanal);
        }

        // Instance Toplama Metodu
        // Mevcut nesnenin(this) üzerine dışarıdan gelen nesneyi ekler.
        public Complex Topla(Complex c)
        {
            return new Complex(this.reel + c.reel, this.sanal + c.sanal);
        }

        // OPERATOR OVERLOADING
        // Neden? Çünkü 'c1.Topla(c2)' yerine 'c1 + c2' daha okunabilir olur.
        public static Complex operator +(Complex c1, Complex c2)
        {
            return Topla(c1, c2);  // Mevcut static metodu çağırarak kod tekrarını önlüyoruz.
        }

        // Karmaşık sayı ile normal bir sayıyı (double) toplama yeteneği
        public static Complex operator +(Complex c, double d)
        {
            return new Complex(c.reel + d, c.sanal);
        }

        /*
         Kodlamaya geçmeden önce, işlemcimize neyi hesaplatacağımızı bilmemiz gerekir:

        Çarpma: (a+bi)⋅(c+di) işlemi dağılma özelliğiyle yapılır.

        (ac+adi+bci+bdi^2)
        Burada i^2 =−1 olduğu için sonuç: (ac−bd)+(ad+bc)i olur.

        Bölme: Paydayı eşleniğiyle çarparak sanal kısımdan kurtarırız.

        c+di/a+bi= (ac+bd)+(bc−ad)i/c^2+d^2​
         */


        // --- ÇARPMA OPERATÖRÜ (*) ---
        public static Complex operator *(Complex c1, Complex c2)
        {
            // Formül: (ac - bd) + (ad + bc)i
            double r = (c1.reel * c2.reel) - (c1.sanal * c2.sanal);
            double s = (c1.reel * c2.sanal) + (c1.sanal * c2.reel);
            return new Complex(r, s);
        }

        // --- BÖLME OPERATÖRÜ (/) ---
        public static Complex operator /(Complex c1, Complex c2)
        {
            // Payda sıfır olamaz (c^2 + d^2)
            double payda = (c2.reel * c2.reel) + (c2.sanal * c2.sanal);

            if (payda == 0)
                throw new DivideByZeroException("Karmaşık sayı sıfıra bölünemez!");

            // Formül: [(ac + bd) / payda] + [(bc - ad) / payda]i
            double r = (c1.reel * c2.reel + c1.sanal * c2.sanal) / payda;
            double s = (c1.sanal * c2.reel - c1.reel * c2.sanal) / payda;

            return new Complex(r, s);
        }

        // --- SKALER ÇARPMA (Complex * double) ---
        // Sadece reel kısmı ve sanal kısmı bir sayıyla çarpmak için alternatif
        public static Complex operator *(Complex c1, double sayi)
        {
            return new Complex(c1.reel * sayi, c1.sanal * sayi);
        }

      /*  public override string ToString()
        {
            // Sanal kısım negatifse görünümü düzeltmek için (örn: 3 + -4i yerine 3 - 4i)
            string isaret = sanal >= 0 ? "+" : "-";
            return $"{reel} {isaret} {Math.Abs(sanal)}i";
      */
            // Akıllı ToString Metodu
            public override string ToString()
            {
                if (reel == 0 && sanal == 0) return "0";
                string str = (reel == 0) ? "" : reel.ToString();

                if (sanal < 0) str += $" - {-sanal}i";
                else if (sanal > 0)
                {
                    if (reel != 0) str += " + ";
                    str += $"{sanal}i";
                }
                return str;
            }
    }
    }
}
