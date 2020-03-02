using System;
using System.Collections.Generic;
using System.Text;
using zadanie1;

namespace zadanie2
{
    class Garaz
    {
        //private string adres;
        //private int liczbaSamochodow = 0;
        //private Samochod[] samochody;


        private string adres;
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }


        private int pojemnosc;
        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }
        
        private int liczbaSamochodow = 0;
        public int LiczbaSamochodow
        {
            get { return liczbaSamochodow; }
        }

        private Samochod[] samochody;
        public Samochod[] Samochody
        {
            get { return samochody; }
        }

        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if(Pojemnosc != liczbaSamochodow)
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }
            else
            {
                Console.WriteLine("Garaż jest już pełny !");
            }
        }

        public void WprowadzSamochod()
        {
            Samochod samochod = new Samochod();

            if (liczbaSamochodow > 0)
            {
                samochod = samochody[liczbaSamochodow - 1];
                samochody[liczbaSamochodow - 1] = null;
                liczbaSamochodow--;
            }

            else
            {
                Console.WriteLine("Garaż jest pusty !");
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Adres garażu: " + adres);
            Console.WriteLine("Pojemność: " + pojemnosc);
            Console.WriteLine("Liczba samochodów: " + liczbaSamochodow);


            Console.WriteLine("Samochody znajdujące się w garażu: ");
            foreach(Samochod samochod in samochody)
            {
                if (samochod != null)
                    samochod.WypiszInfo();
            }
        }
    }

}
