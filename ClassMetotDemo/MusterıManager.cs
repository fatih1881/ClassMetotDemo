using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusterıManager
    {
        public void ekle(Musteri musterıler)
        {
            Console.WriteLine($"{musterıler.Adi} {musterıler.Soyadi} eklendi ");
            Console.WriteLine("---------------");
        }
        public void sil(Musteri musterıler)
        {
            Console.WriteLine($"{musterıler.Adi} {  musterıler.Soyadi} silindi");
            Console.WriteLine("-------------");
        }
            public void listele(Musteri[] musterıler) 
            {
            foreach (Musteri musteri in musterıler)
            {
                Console.WriteLine("Musterı Id : " + musteri.Id);
                Console.WriteLine(" Musterı Adı : " + musteri.Adi);
                Console.WriteLine("Musterı Soyadı : "+musteri.Soyadi);


            }
            {

            }
            }

        }
    }

