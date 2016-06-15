using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrrad f1 = new Fahrrad();
            Auto a1 = new Auto();
            f1.information();
            a1.information();
            Console.ReadKey();
        }
    }

    class Fahrzeug
    {
        // Propertys
        protected int anzahlRaeder { get; set; }
        protected string name {get; set;}
        
        //Methode
        public void information()
        {
            Console.WriteLine("Räder: "+this.anzahlRaeder.ToString());
            Console.WriteLine("Name: "+this.name);
        }
    }

    class Fahrrad : Fahrzeug
    {

        public Fahrrad()
        {
            this.anzahlRaeder = 2;
            this.name = "Fahrrad";
        }

    }

    class Auto : Fahrzeug
    {
        public Auto()
        {
            this.anzahlRaeder = 4;
            this.name = "Auto";
        }
    }
}
