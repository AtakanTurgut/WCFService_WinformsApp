using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_1_wcfservice
{
    public class Hizmetli : Personel
    {
        public override void maasHesapla()
        {
            base.maasHesapla();
            if (haftalikCalismaSaati <= 30)
            {
                this.maas = maas * 2;
            } else
            {
                this.maas = (maas * 2) + ((haftalikCalismaSaati - 30) * 40);
            }
        }
    }
}