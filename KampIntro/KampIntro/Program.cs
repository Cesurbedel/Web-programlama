using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategori";
            int OgrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;


            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (DolarDun<DolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş yap");
            }

            Console.WriteLine(KategoriEtiketi);

        }
    }
}
