using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3Kapsulleme
{
    internal class Ogrenci
    {
        // Private degiskenleri veya metotları doğrudan program içerisinde erişemediğimiz için
        // kapsülleme (encapsulation) kullanıyoruz.
        // Kapsülleme, bir sınıfın içindeki verilerin ve işlevlerin dışarıdan erişimini kontrol etmek için kullanılır.
        // Bu, verilerin gizliliğini sağlar ve sınıfın iç yapısını korur.
        // Kapsüllemeyi, getter ve setter metotları kullanarak gerçekleştirebiliriz.

        private string Isim;

        public void setIsim(string isim)
        {
            Isim = isim;
        }

        public string getIsim()
        {
            return Isim;
        }
    }
}
