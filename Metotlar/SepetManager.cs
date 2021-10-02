using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler!"+ urun.Adi + ", sepete eklendi");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)
        {
            Console.WriteLine("tebrikler.Ürün eklendi: "+ urunAdi);
        }
    }
}
