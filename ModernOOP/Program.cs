using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Duygu";
            o1.Soyad = "Tezcan Kantar";
            o1.Sehir = "İstanbul";
            o1.Cadde = "Ayvansaray";
            o1.Id = 1;
            o1.Ilce = "Ataşehir";
            o1.KapiNo = 7;
            o1.Cinsiyet = "K";


            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Serkan";
            o2.Soyad = "Kantar";
            o2.Sehir = "İstanbul";
            o2.Cadde = "Atatürk";
            o2.Id = 1;
            o2.Ilce = "Ataşehir";
            o2.KapiNo = 7;
            o2.Cinsiyet = "E";


            Ogrenci[] ogrenciler = { o1, o2 };
            foreach (var item in ogrenciler)
            {
                //Console.WriteLine(item.Ad + item.Soyad);
                Console.WriteLine(item.Unvan());
            }
            Console.ReadLine();


            /*for (int i = 0; i < ogrenciler.Length; i++)
            {
              Console.WriteLine(ogrenciler[i].Ad + ogrenciler[i].Soyad);
            }
            Console.ReadLine();*/

        }
    }
}
