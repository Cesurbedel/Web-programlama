using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 40;
            urun2.Aciklama = "Sabirabad karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("----------Metotlar-------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil", 12, 10);
            sepetManager.Ekle2("Elma", "Kirmizi", 50, 80);
            sepetManager.Ekle2("karpuz", "Sabirabad karpuzu", 45, 35);


        }
    }
}



//Dont repeat yourself - DRY - Clean Code - Best Practice
