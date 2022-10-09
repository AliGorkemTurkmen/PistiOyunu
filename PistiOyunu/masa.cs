using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiOyunu
{
    public class masa
    {
        private oyuncu[] oyuncular;
        private Deste deste;
        private List<kart> yer;
        private static readonly Random random = new Random();
           
        public masa(int oyuncu_sayisi)
        {
            oyuncular = new oyuncu[oyuncu_sayisi];
            deste = new Deste();
            deste.Karistir();
            yer = new List<kart>();

            for (int i = 0; i < oyuncu_sayisi; i++)
            {
                oyuncular[i] = new oyuncu("oyuncu" + i);
            }
            yer = deste.KartVer(4);
            Dagit();
            TurOyna();
        }

        private void Dagit()
        {
            if(deste.KartSay() > 0)
            {
                foreach (var oyuncu in oyuncular)
                {
                    oyuncu.KartAL(deste.KartVer(4));
                }
            }
        }

        private bool KuralKontrol(kart atilan)
        {
            if (yer.Count > 1)
            {
                kart en_ustteki_kart = yer.LastOrDefault();
                if (yer.LastOrDefault().ValeMi() || atilan.BenzerMi(en_ustteki_kart))
                {
                    return true;
                }   
            }
            return false;   
        }


        private void TurOyna()
        {
            foreach  (oyuncu o in oyuncular)
            {
                int atilacak_kart_index = random.Next(o.KartSay());
                kart atilan = o.At(atilacak_kart_index);

                //Kural kontrolü buraya gelecek
                if (KuralKontrol(atilan))
                {
                    yer.Add(atilan);
                    o.Topla(yer);
                    yer.Clear();
                }
                else
                {
                    yer.Add(atilan);
                }
            }
        }

        public void ElOyna()
        {
            oyuncu son_oyuncu = oyuncular.LastOrDefault();
            Dagit();
            do
            {
                TurOyna();

            } while (son_oyuncu.KartSay() > 0);
        }

        public void OyunOyna()
        {
            while (deste.KartSay() > 0)
            {
                ElOyna();   
            }
        }

        public override string ToString()
        {
            string oyuncular_str = string.Join("\n", oyuncular.ToList());
            string yer_str = string.Join(", ", yer);
            return string.Format("Deste ({0}): \nYer: {1}\nOyuncular: \n{2}", deste.KartSay(), yer_str, oyuncular_str);
        }
    }
}
