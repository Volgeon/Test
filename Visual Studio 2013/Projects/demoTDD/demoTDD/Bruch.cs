using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testDemoTDD
{
    public class Bruch
    {
        public double Zaehler { get; set; }
        public double Nenner  { get; set; }

        private double groß_bruch;
        private double klein_bruch;
        private int ggt_zahl;

        public Bruch(double z, double n)
        {
            Zaehler = z;
            Nenner = n;
        }

        public double quotient()
        {
            if (Nenner == 0) throw new DivideByZeroException();
            return Zaehler / Nenner;
        }

        public void ggt()
        {
            if (Zaehler > Nenner) {
                groß_bruch = Zaehler;
                klein_bruch = Nenner;
            }
            else
            {
                groß_bruch = Nenner;
                klein_bruch = Zaehler;
            }
            while (klein_bruch != 0)
            {
                ggt_zahl = (int)groß_bruch / (int)klein_bruch;  //ggt_zahl = Ergebnis
                klein_bruch = (groß_bruch % klein_bruch);   //klein_bruch = Rest vom Ergebnis
            }
        }

        public void kuerzel()
        {
            this.ggt();
            Zaehler /= ggt_zahl;
            Nenner /= ggt_zahl;
        }

    }
}
