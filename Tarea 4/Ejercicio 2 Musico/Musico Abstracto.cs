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

            Bajista b = new Bajista("Flea", "La Bajista");

            Guitarrista g = new Guitarrista("Santana", "El Gitarrista");

            Musico[] m = new Musico[2];

            m[0] = b;

            m[1] = g;

            foreach (Musico y in m)
            {
                Console.WriteLine(y.nombre);
            }

        Console.ReadKey();
        }
    }
}
