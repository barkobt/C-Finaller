using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._1
{
    public class Ogrenci
    {
        private string OgrenciNo;
        private string Ad;
        private string Soyad;
        private int vize1;
        private int vize2;
        private int final;
        private string OkulIsmi;


        public Ogrenci(string OgrenciNo, string Ad, string Soyad,int vize1, int vize2, int final, string OkulIsmi)
        {
            this.OgrenciNo = OgrenciNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.OkulIsmi = OkulIsmi;
        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası: " + OgrenciNo);
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Vize 1: " + vize1);
            Console.WriteLine("Vize 2: " + vize2);
            Console.WriteLine("Final: " + final);
            Console.WriteLine("Okul İsmi: " + OkulIsmi);
        }

        public double ogrenciOrtalamasıBul()
        {
            double ortalama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
            return ortalama;

        }
    }
}
