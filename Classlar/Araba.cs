using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaRenk;
        public string arabaModel;
        public Araba(int kapiSayisi,  string arabaRenk,string arabaModel) // Constructor Metodu , ilk çalışma anında çalışan metot
        {
            this.kapiSayisi = kapiSayisi;
            this.arabaRenk = arabaRenk;
            this.arabaModel = arabaModel;
        }

       

        public void motorCalistir()
        {
            Console.WriteLine("Motor çalıştı.");

        } 

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar kilitlendi.");
        }

    }
}
