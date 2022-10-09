using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiOyunu
{
    public class kart
    {
        private string yuz;
        private string deger;
        private int puan;

        //Yapıcı metot (constructor): new operatörü ile çağırırlan metot yapısıdır. void veya geri dönüş tipi bulunmaz. sınıfın adıyla aynı adı taşımak zorundadır. ilj oluşturma anında başlangıç kodlarını buraya yazarız. 
        public kart(string y, string d)
        {
            yuz = y;
            deger = d;  
            puan = 0;
            if (d == "Vale" || d == "As")
            {
                puan = 1;
            }

            else if (d == "2" && y == "Sinek")
            {
                puan = 2;
            }
            else if (d == "10" && y == "Karo")  
            {
                 puan =3;
            }
            else
            {
                puan =0;
            }
        }
        //Var olan temel fonksiyonlardan biri olan ToString yeniden yazıldı.
        public override string ToString()
        {
            // return  "["+yuz +" " + deger + "("+ puan +")]";
            //return string.Format("[{0} {1} ({2}p)]",yuz, deger, puan);
            return $"[{yuz} {deger} ({puan}p)";
        }

        public bool ValeMi()
        {
            return deger == "Vale";
        }

        public bool BenzerMi(kart kart)
        {
            return deger == kart.deger;
        }
    }
}
