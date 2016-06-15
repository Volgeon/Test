using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma_Werke_Produkt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objekte erzeugen
            //- Firma
            Firma f1 = new Firma();
            //- Werke
            Werk w1 = new Werk();
            Werk w2 = new Werk();
            //- Produkte
            Produkt p1 = new Produkt(7000, (float)195.50, "4TB Festplatte");
            Produkt p2 = new Produkt(6000, (float)149.90, "250GB SSD");
            //- Produkte in Werke
            w1.produkt = p1;
            w2.produkt = p2;
            //- Werke in Firma
            f1.addWerke(w1);
            f1.addWerke(w2);
            //Ausgabe
            Console.WriteLine(f1.berechneGesamtumsatz());
            Console.ReadKey();
        }
    }

    class Firma
    {
        private List<Werk> werkList = new List<Werk>();
        
        public float berechneGesamtumsatz()
        {
            float result = 0;
            foreach (Werk w in werkList)
            {

                result += w.berechneGesamtumsatz();
            }

            return result;
        }

        public void addWerke(Werk p_werk){
            this.werkList.Add(p_werk);
        }

    }

    class Werk
    {

        public Produkt produkt { get; set; }

        public float berechneGesamtumsatz()
        {
            return (this.produkt.anzahl * this.produkt.preis);
        }

    }

    class Produkt
    {

        public int anzahl { get; set; }
        public float preis { get; set; }
        public string name { get; set; }

        public Produkt(int p_anzahl, float p_preis, string p_name)
        {
            this.anzahl = p_anzahl;
            this.preis = p_preis;
            this.name = p_name;
        }

    }

}
