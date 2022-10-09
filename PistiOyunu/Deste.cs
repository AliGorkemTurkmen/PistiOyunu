using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiOyunu
{
    public class Deste
    {
        private List<kart> kartlar;
        //Rastgele  sistemi bu saturu standart olarak kullanır.next metodunun her seferinde yeni değer vermesi için bu şekilde eklenir
        private static readonly Random random = new Random();
        public Deste()
        {
            kartlar = new List<kart>(); 
            string[] yuzler = { "Sinek", "Maça", "Karo", "Kupa" };
            string[] degerler = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };

            foreach (var yuz in yuzler)
            {
                foreach (var deger in degerler)
                {
                    kart kart = new kart(yuz, deger);
                    kartlar.Add(kart);
                }
            }
        }

        public void Karistir()
        {
            for (int i = 0; i < 50; i++)
            {
                int ilkYariKartAdresi = random.Next(26); //0 - 25 arası ratgele bir değer üretir.
                int ikinciYariKartAdresi = random.Next(26, 52); //26 -51 arası  ratgele bir değer üretir.                                       
                kart bos = kartlar[ilkYariKartAdresi];
                kartlar[ilkYariKartAdresi] = kartlar[ikinciYariKartAdresi];
                kartlar[ikinciYariKartAdresi] = bos;
            }
        }

        public int KartSay()
        {
            return kartlar.Count;

        }
        public List<kart>KartVer(int kart_sayisi)
        {
            List<kart> verilecekler = kartlar.Take(kart_sayisi).ToList();
            kartlar.RemoveRange(0, kart_sayisi);
            return verilecekler;
        }
    
            
        public override string ToString()   
        {
            return string.Join(", ", kartlar);
        }
    }
}
