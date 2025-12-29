using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriUygulamasi
{
    public class Rectangle
    {
        private int en;
        private int boy;

        public Rectangle() { }

        public Rectangle(int e, int b) { en = e; boy = b; }

        public Rectangle(int e) { en = e; boy = e; } // Kare olusturma durumu

        public int En
        {
            get => en;
            set => en = Math.Abs(value); // Negatif girilse bile pozitife çevirir
        }

        public int Alan() => en * boy;
        public int Cevre() => 2 * (en + boy);
        public double Diagonal() => Math.Sqrt(en * en + boy * boy);

        public override string ToString()
        {
            return $"Boyutlar: {en}x{boy}\nAlan: {Alan()}\nÇevre: {Cevre()}\nKösegen: {Diagonal():F2}\n----------------------";
        }
    }
}
