using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BANKSOFTWARE_ULTRA_LIGHT
{
    class Program
    {

        List<Konto> konten = new List<Konto>;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Willkommen!");
            Console.WriteLine();
            Console.WriteLine("1 - Einloggen");
            Console.WriteLine("2 - Neues Konto");
            Console.WriteLine("3 - Verlassen");
            Console.WriteLine();
            Console.Write("Eingabe: ");
            int input = Int16.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    einloggen();
                    break;
                case 2:
                    neuesKonto();
                    break;
                case 3:
                    break;
            }
        }

        public static void einloggen()
        {
            Console.Clear();
            Console.WriteLine("Einloggen");
            Console.WriteLine();
            Console.WriteLine("ID: ");
            int ip_id = Int16.Parse(Console.ReadLine());
            Console.WriteLine("PW: ");
            string ip_pw = Console.ReadLine();
        }

        public static void neuesKonto()
        {
            Console.Clear();
            Console.WriteLine("Neues Konto");
            Console.WriteLine();
            Console.WriteLine("Sie sind dabei ein neues Konto zu erstellen. Geben Sie zuerst den Namen des Inhabers ein!");
            Console.Write("Inhaber: ");
            string newInhaber = Console.ReadLine();
            Console.WriteLine("Nun geben Sie Ihr Passwort ein!");
            string newPasswort = Console.ReadLine();
            Console.WriteLine("Nun geben Sie Ihr Startkontostand ein");
            int newKontostand = Int16.Parse(Console.ReadLine());
            // Bildschirm leer
            Console.Clear();
            // Zuweisung
            konten[konten.Length] = new Konto(konten.Length - 1, newInhaber, newPasswort, newKontostand);
            // Anzeige
            Console.WriteLine("Hier sind Ihre Eingaben!");
            konten[konten.Length - 1].status();
        }
    }

    class Konto
    {
        int id;
        string inhaber;
        string passwort;
        int kontostand;

        public Konto(int pId, string pInhaber, string pPasswort, int pKontostand)
        {
            this.id = pId;
            this.inhaber = pInhaber;
            this.passwort = pPasswort;
            this.kontostand = pKontostand;

        }

        public void status()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Inhaber: " + this.inhaber);
            Console.WriteLine("Passwort: " + this.passwort);
            Console.WriteLine("Kontostand: " + this.kontostand);
        }
    }
}
