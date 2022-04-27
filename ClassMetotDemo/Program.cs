using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Ad = "Ali";
musteri1.Soyad = "Candan";
musteri1.DogumYili = 2001;

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Ad = "Aslan";
musteri2.Soyad = "Akbey";
musteri2.DogumYili = 1972;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

MusteriManager musteriManager1 = new MusteriManager();
musteriManager1.Ekle(musteri1);
musteriManager1.Ekle(musteri2);

foreach (var musteri in musteriler)
{
    musteriManager1.Listele(musteri);
}

musteriManager1.Sil(musteri2);