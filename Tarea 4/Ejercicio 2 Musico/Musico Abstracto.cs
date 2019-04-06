using System;
using System.Collections.Generic;

namespace Ejercicio_2_Musico
{
    abstract class Musico
    {
        public string nombre;

        public Musico(string n)
        {
            nombre = n;
        }

        public abstract void Afina(); 

         public string Display()
         {
            return nombre;
         }
    }

    class Bajista : Musico
    {
        public string instrumento;

        public Bajista(string n, string i):base(n)
        {
            nombre = n;
            instrumento = i;
        }

        public override void Afina()
        {
            Console.WriteLine("Bajista");
        }
    }

    class Guitarrista: Musico
    {
        public string instrumento;

        // Falta el constructor y otras cosas??
        public Guitarrista(string n, string i) : base(n)
        {
            nombre = n;
            instrumento = i;
        }

        public override void Afina()
        {
            Console.WriteLine("Guitarrista");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Musico m = new Musico("Django"); //(D) no se puede crear

            Bajista b = new Bajista("Flea", "hiperBajo");

            Guitarrista g = new Guitarrista("Santana", "GuitarraSonica");

            List<Musico> m = new List<Musico>();
            m.Add(b);
            m.Add(g);

            foreach (Musico mu in m)
            {
                Console.WriteLine(mu.nombre);
            }

        Console.ReadKey();
        }
    }
}
