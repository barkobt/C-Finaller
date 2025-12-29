using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4Property
{
    internal class Musteri
    {
        private int kilo;

        public int KILO
        {
            get
            {
                return kilo;
            }

            set
            {
                if (value < 10)
                    kilo = 0;
                else
                    kilo = value;

            }

        }
    }
}
