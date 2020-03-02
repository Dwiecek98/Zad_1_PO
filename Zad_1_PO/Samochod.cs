using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie1
{
    class Samochod
    {
        // jeżeli zmienna jest prywatna i readonly - private readonly int _iloscDrzwi;
        // 

        private string model = " ";
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int liczbaSamochodow = 0;
        

        private string marka = " ";

        private string numerRejestracyjny;

        public string NumerRejestracyjny
        {
            get { return numerRejestracyjny; }
            set { numerRejestracyjny = value; }
        }


        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        // public string Marka { get; set; } krótszy sposób

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public double LiczbaSamochodow
        {
            get { return liczbaSamochodow; }
        }

        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;
            liczbaSamochodow++;
        }

        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
            liczbaSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100.0;
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100.0;
            double kosztPrzejazdu = spalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemność silnika: " + pojemnoscSilnika);
            Console.WriteLine("Średnie spalanie: " + srednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Liczba samochodów: " + liczbaSamochodow);
        }

        //public override string ToString() //nadpisujemy metodę która jest dostępna dla wszystkich obiektów - ToString() - żeby zwracała nam stringa jak niżej 
        //{
        //    return $"To jest samochód: {this.Marka}";
        //}
    }
}
