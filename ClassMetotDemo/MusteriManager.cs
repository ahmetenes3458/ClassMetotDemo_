using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sil : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi : ");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
        }
    }
}
