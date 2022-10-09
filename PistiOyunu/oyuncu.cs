using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiOyunu
{
    public class oyuncu
    {
        private string ad;
        private int puan;
        private List<kart> toplanan;
        private List<kart> el;

        public oyuncu(string a)
        {
            ad = a;
            puan = 0;
            toplanan = new List<kart>();
            el = new List<kart>();
        }

        public void KartAL(List<kart> kartlar)
        {
            el = kartlar;
        }

        public void Topla(List<kart> yerdekiler)
        {
            toplanan.AddRange(yerdekiler);
        }

        public kart At(int kart_index)
        {
            kart atilacak = el[kart_index];
            el.RemoveAt(kart_index);
            return atilacak;
        }

        public int KartSay()
        {
            return el.Count;
        }

        public override string ToString()
        {
            string el_str = string.Join(", ", el);
            string toplanan_str = string.Join(", ", toplanan);


            /* return
                 $"{ad} ({puan}p):\n" +
                    $"El: {string.Join(",", el)}";
                    $"Toplanan: {string.Join(", ", toplanan)}"; */

            return string.Format("{0}  ({1}p): \nEl: {2}\nToplanan: {3}", ad, puan, el_str, toplanan_str);
        }
    }
}
