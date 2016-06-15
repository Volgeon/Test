using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VorbereitungArbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch m1 = new Mensch("Evans", "Männlich");
            m1.informationen();
            Console.ReadKey();
        }
    }

    class Lebewesen {

        //Property
        protected string art;
        protected string name { get; set;}
        protected string geschlecht { get; set; }

        //Methoden
    }

    class Mensch : Lebewesen
    {
        public Mensch(string p_name, string p_geschlecht)
        {
            this.art = "Mensch";
            this.name = p_name;
            this.geschlecht = p_geschlecht;
        }

        public void informationen()
        {
            Console.WriteLine(this.name + this.geschlecht);
        }
    }

    class Tier : Lebewesen
    {
        public Tier()
        {
            this.art = "Tier";
        }
    }
}