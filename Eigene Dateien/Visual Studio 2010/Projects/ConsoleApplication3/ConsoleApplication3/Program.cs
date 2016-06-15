using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe
            Console.WriteLine("Gebe die Anzahl der Kartons an!");
            int anzahl = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Gebe die Kilometer-Strecke an!");
            int kilometer = int.Parse(Console.ReadLine());
            Console.Clear();

            //Verarbeitung
            double netto = 7.85 * anzahl;

            int bruttogewicht = anzahl * 24;
            int nettogewicht = bruttogewicht;

            double fracht;
            int zähler = 0;
            while (nettogewicht > 0) {
             zähler += 1;
             nettogewicht -= 100;
            }
            int berechnetesgewicht = 100 * zähler;
            fracht = kilometer * 0.06 * zähler;

            double nettoumsatz = 7.85 * 12 * anzahl;
            double gesamt = nettoumsatz + fracht;
            double rabatt = 0;
            if (nettoumsatz <= 10000) {
                rabatt = 3;
            } else if (nettoumsatz <= 50000) {
                rabatt = 5;
            } else {
                rabatt = 7;
            }

            rabatt = rabatt / 100;
            rabatt = nettoumsatz * rabatt;
            double zielpreis = gesamt - rabatt;

            //Ausgabe
            Console.WriteLine("Anzahl Kartons:                    " + anzahl);
            Console.WriteLine("Kilometer:                         " + kilometer);
            Console.WriteLine("Gewicht:                           " + bruttogewicht);
            Console.WriteLine("Berechnetes Gewicht:               " + berechnetesgewicht);
            Console.WriteLine("Fracht:                            " + fracht);
            Console.WriteLine("Nettoumsatz (Umsatz ohne Fracht):  " + nettoumsatz);
            Console.WriteLine("Gesamtumsatz (Umsatz mit Fracht):  " + gesamt);
            Console.WriteLine("Rabatt:                            " + rabatt);
            Console.WriteLine("Zielpreis:                         " + zielpreis);
            Console.ReadKey();

        }
    }
}
