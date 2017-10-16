using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bısıkletuygulama
{
    class Bisiklet
    {
        int hiz, vites, vitesSayisi, tekerCapı; // Default Private
        public static int bsayisi;
        
        public Bisiklet() // Kurucu Metod
        {
            vitesSayisi = 6;
            bsayisi++;
        }
         public Bisiklet(int v) // kurucu metod aşırı yükleme
         {
             vitesSayisi = v;
             bsayisi++;

         }
        public void Hizlan(int artis) {
            hiz +=artis;

        }

        public void FrenYap(int azalis) {
            vites = yenideger;

        }
        public void BilgileriYaz(){
            Console.WriteLine("Şu anki hiziniz : {0}", hiz);
            Console.WriteLine("Şu anki vitesiniz : {0}", vites);
            Console.WriteLine("En yüksek Vites {0}", vitesSayisi);
        }

        
    }
    class Program
    {

    static void Main(string[] args)
        {

            Bisiklet b1 = new Bisiklet();
            Bisiklet b2 = new Bisiklet();
            Bisiklet b3 = new Bisiklet(15);
            Bisiklet b4 = new Bisiklet(21);
            Bisiklet b5 = new Bisiklet(18);

        b1.Hizlan(10);
        b1.VitesDegiştir(3);
        b1.BilgileriYaz();
        b1.FrenYap(5);
        b1.VistesDegiştir(2);
        b1.BilgileriYaz();

        Console.WriteLine("Toplam Bisiklet Sayisi : ");
        + Convert.ToString(Bisiklet.bsayisi));
    }
}
