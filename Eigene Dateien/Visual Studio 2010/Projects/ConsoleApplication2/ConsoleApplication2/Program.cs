using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Variablen
            int frachtkosten;
            float nettopreis;
            int kartons;
            int bruttogewicht;

            // Eingabe
            System.Console.WriteLine("Gebe die Anzahl der Kartons ein: ");
            kartons = int.Parse(Console.ReadLine());

            // Berechnung
            nettopreis = (float) 7.85 * kartons * 12;
            
            System.Console.WriteLine(nettopreis);
            //onsole.ReadLine();

        }

    }

}
