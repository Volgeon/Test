using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Penner
    {
        void pennern()
        {
            Console.WriteLine("Hallo ich will pennern");
        }

        internal void pennern()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
    class Lolmeister
    {
        static void betteln(Penner Joseph)
        {
            Joseph.pennern();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Program> list = new List<Program>;
            list[0].
        }

        void methode_ausführen()
        {
        }
    }
}
