using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.Id = 1;
                musteri1.Adi = "Fatih ";
                musteri1.Soyadi = "KORKMAZ";

                Musteri musteri2 = new Musteri();
                musteri2.Id = 2;
                musteri2.Adi = "Duygu ";
                musteri2.Soyadi = "PAHLİ";

                Musteri musteri3 = new Musteri();
                musteri3.Id = 3;
                musteri3.Adi = "Melike ";
                musteri3.Soyadi = "KORKMAZ";


                Musteri[] musterıler = new Musteri[] { musteri1, musteri2, musteri3 };

                foreach (Musteri musteri in musterıler)
                {
                    Console.WriteLine("Müşteri ID : "+musteri.Id);
                    Console.WriteLine("Müşteri Adı : "+ musteri.Adi);
                    Console.WriteLine("Müşteri Soyadı : "+ musteri.Soyadi);
                    Console.WriteLine("-----------------"); 
                }
                MusterıManager eklemeislemi = new MusterıManager();
                eklemeislemi.ekle(musteri1);
                eklemeislemi.ekle(musteri2);
                eklemeislemi.ekle(musteri3);
                Console.WriteLine("---------");

                MusterıManager silmeislemi = new MusterıManager();
                silmeislemi.sil(musteri1);
                silmeislemi.sil(musteri2);
                silmeislemi.sil(musteri3);
                Console.WriteLine("---------");

                MusterıManager listeleislemi = new MusterıManager();
                listeleislemi.listele(musterıler);
                


            }
        }
    }
}
