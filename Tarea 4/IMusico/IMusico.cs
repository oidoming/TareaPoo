using System;
using System.Collections.Generic;

interface IMusico
    {
        string nombre {get; set;}

        void Afina();

        string Display();
    }

    class Bajista : IMusico
    {
        public string nombre {get; set;}
        public string instrumento {get; set;}

        public Bajista(string n, string i)
        {
            nombre = n;
            instrumento = i;
        }

        public void Afina()
        {
            Console.WriteLine("Bajista");
        }

        public string Display()
        {
            return nombre;
        }
    }

    class Guitarrista : IMusico
    {
        // Falta el constructor y otras cosas??
        public string nombre { get; set; }
        public string instrumento { get; set; }

        public Guitarrista(string n, string i)
        {
            nombre = n;
            instrumento = i;
        }

        public void Afina()
        {
            Console.WriteLine("Guitarrista");
        }

        public string Display()
        {
            return nombre;
        }

    }

    class Program1
    {
        static void Main(string[] args)
        {
            //Musico m = new Musico("Django"); //(D) no se puede crear

            Bajista b = new Bajista("Flea", "La Bajista");

            Guitarrista g = new Guitarrista("Santana", "El Gitarrista");

            IMusico[] m = new IMusico[2];

            m[0] = b;

            m[1] = g;

            foreach (IMusico y in m)
            {
                Console.WriteLine(y.nombre);
            }

            Console.ReadKey();
        }
    }
