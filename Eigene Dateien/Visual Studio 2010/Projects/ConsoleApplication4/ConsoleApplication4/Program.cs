using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Konto
    {
        String s_besitzer;
        String s_passwort;
        double d_kontostand;
        double d_disposition;
        double d_zinssatz;
        

        static void Main(string[] args)
        {
            List<Konto> a_liste = new List<Konto>();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Banksoftware ,,ultra-light''");
                Console.WriteLine();
                Console.WriteLine("1 - Konto erstellen");
                Console.WriteLine("2 - einloggen");
                Console.WriteLine("0 - beenden");
                Console.WriteLine();
                Console.Write("Eingabe: ");

                try
                {
                    loop = false;
                    int a = Convert.ToInt32(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Konto erstellen");
                                Console.WriteLine();
                                Konto newKonto = new Konto();
                                Console.Write("Name: ");
                                newKonto.s_besitzer = Console.ReadLine();
                                Console.Write("Passwort: ");
                                newKonto.s_passwort = Console.ReadLine();
                                int i = a_liste.Count;
                                a_liste.Add(newKonto);
                                Console.WriteLine();
                                Console.WriteLine("Du hast folgendes Konto erstellt:");
                                Console.WriteLine();
                                Console.WriteLine("Besitzer: " + a_liste[i].s_besitzer);
                                Console.WriteLine("Passwort: " + a_liste[i].s_passwort);
                                Console.WriteLine();
                                Console.WriteLine("Du hast die folgende Konto-ID: " + i);
                                Console.WriteLine("Du benötigst die Konto-ID für die Anmeldung");
                                Console.ReadKey();
                                Console.Clear();
                                loop = true;
                                break;
                            case 2:
                                break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Nicht numerischer Zeichensatz eingegeben!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        void eingeloggt()
        {
            Konto myKonto = new Konto();
            int a = 1;

            while (a > 0)
            {

                try
                {
                    Console.Clear();
                    Console.WriteLine("Banksoftware ,,ultra-light''");
                    Console.WriteLine();
                    Console.WriteLine("1 - einzahlen");
                    Console.WriteLine("2 - abbuchen");
                    Console.WriteLine("0 - ausloggen");
                    Console.WriteLine();
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Du hast einen nicht numerischen Zeichensatz eingegeben! Du Trottel!");
                    Console.ReadKey();
                }

                Console.Clear();
                switch (a)
                {
                    case 0:
                        Console.WriteLine("Sie haben beenden gewählt: Drücken Sie eine beliebige Taste zum beenden");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.WriteLine("Sie haben einzahlen gewählt!");
                        Console.WriteLine();
                        Console.WriteLine("Wie viel Geld möchten Sie einzahlen?");
                        Console.WriteLine();
                        Console.Write("Eingabe: ");
                        try
                        {
                            Console.Clear();
                            double einzahlen = double.Parse(Console.ReadLine());
                            myKonto.einzahlen(einzahlen);
                            Console.WriteLine();
                            Console.WriteLine("Ihr neuer Kontostand beträgt: " + myKonto.getKontostand() + "Euro");
                            Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Konnte nicht einzahlen: Nicht numerischer Zeichensatz eingegeben!");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Sie haben abbuchen gewählt!");
                        Console.WriteLine();
                        Console.WriteLine("Wie viel Geld möchten Sie abbuchen?");
                        Console.WriteLine();
                        double abbuchen = double.Parse(Console.ReadLine());
                        myKonto.abbuchen(abbuchen);
                        Console.WriteLine();
                        Console.WriteLine("Ihr neuer Kontostand beträgt: " + myKonto.getKontostand() + "Euro");
                        Console.WriteLine();
                        break;
                }
            }
        }

        void konto(String my_s_besitzer, double my_d_kontostand, double my_d_disposition, double my_d_zinssatz)
        {
            s_besitzer = my_s_besitzer;
            d_kontostand = my_d_kontostand;
            d_disposition = my_d_disposition;
            d_zinssatz = my_d_zinssatz;
        }

        void einzahlen(double einzahlen) 
        {
            d_kontostand += einzahlen;
        }

        void abbuchen(double abbuchen)
        {
            d_kontostand -= abbuchen;
        }

        double getKontostand()
        {
            return d_kontostand;
        }
    }
}