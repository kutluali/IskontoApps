using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskontoHesaplamaUyg
{
    public class Hesaplama
    {
        public double IskontoHesapla(double listeFiyati, double i1, double i2, double i3)
        {
            double indirimliFiyat = listeFiyati * (1 - i1 / 100) *
                (1 - (i2 != 0 ? i2 / 100 : 0)) *
                (1 - (i2 != 0 ? i3 / 100 : 0));
            return indirimliFiyat;
        }


        public double KdvliHesapla(double urunFiyati, double kdvOrani)
        {
            double kdvDahil = urunFiyati * (1 + kdvOrani / 100);
            return kdvDahil;
        }

    }
}
