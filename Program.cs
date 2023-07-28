using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(15);
            sayiListesi.Add(87);
            sayiListesi.Add(42);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve List.ForEach ile elemanlara eriişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listede arama
            if (sayiListesi.Contains(9))
                Console.WriteLine("10 liste içerisinde bulundu.");

            //Eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sayı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Liste temizleme
            hayvanlarListesi.Clear();

            //Liste içerisinde nesne tutmank
            List<Kullanicilar> kullanicilars = new List<Kullanicilar>();
            Kullanicilar k1 = new Kullanicilar();
            k1.Isim = "ayşe";
            k1.Soyisim = "yılmaz";
            k1.Yas = 26;

            Kullanicilar k2 = new Kullanicilar();
            k2.Isim = "özcan";
            k2.Soyisim = "çalışkan";
            k2.Yas = 22;

            kullanicilars.Add(k1);
            kullanicilars.Add(k2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "arda",
                Yas = 35
            });

            foreach (var kullanici in kullanicilars)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: " + kullanici.Yas);
            }

        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
