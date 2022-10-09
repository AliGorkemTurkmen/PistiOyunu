using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistiOyunu
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //*
            //    kart kart = new kart("Sinek", "2");
            //    Console.WriteLine(kart);
            //*/  

            //    //Temel deste oluştur.
            //    Deste deste = new Deste();
            //    Console.WriteLine(deste);

            //    //Desteyi karıştır
            //    deste.Karistir();
            //    Console.WriteLine(deste);

            //    //Desteyi yeniden oluştur   
            //    deste = new Deste();
            //    Console.WriteLine(deste);

            //    Console.WriteLine(deste.KartSay());
            //    List<kart> verilenler = deste.KartVer(4);
            //    Console.WriteLine(deste.KartSay());
            //    Console.WriteLine(String.Join(", ",verilenler));

            masa masa = new masa(4);
            Console.WriteLine(masa);
            masa.ElOyna();
            Console.WriteLine();
            Console.WriteLine(masa);
            masa.OyunOyna();
            Console.WriteLine();
            Console.WriteLine(masa);
        }
    }
}
