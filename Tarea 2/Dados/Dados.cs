using System;

namespace Dados
{
class Dado
    {
        private int Valor;
        public string color;

        public Dado(int Valor)
        {
            this.Valor = Valor;
        }

        public Dado(string color)
        {
            this.color = color;
        }

        public void Imprimir()
        {
            Console.WriteLine("El dado de color {0} es el mayor",color);
        }

        public static bool operator <(Dado d1, Dado d2)
        {

            return true;

        }

        public static bool operator >(Dado d1, Dado d2)
        {

            return true;

        }

        public static bool operator ==(Dado d1, Dado d2)
        {
           
            return true;
        }

        public static bool operator !=(Dado d1, Dado d2)
        {
           
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dado d1 = new Dado(6);
            d1.color = "Amarillo";

            Dado d2 = new Dado(4);
            d2.color = "Blanco";

            Dado d3 = new Dado(2);
            d3.color = "Verde";

            if (d1 > d2 && d1 > d3)
            {
                d1.Imprimir();
            }
            else if (d2 > d1 && d2 > d3)
            {
                d2.Imprimir();
            }
            else if (d3 > d1 && d3 > d2)
            {
                d3.Imprimir();
            }
            else if (d1 == d2 )
            {
                Console.Write("Los dados {0} y {1} tienen el mismo valor", d1.color, d2.color);
            }
            else if (d1 == d3)
            {
                Console.Write("Los dados {0} y {1} tienen el mismo valor", d1.color, d3.color);
            }
            else if (d2 == d3)
            {
                Console.Write("Los dados {0} y {1} tienen el mismo valor", d2.color, d3.color);
            }
            else
            {
                Console.Write("Los dados tienen el mismo valor");
            }

            Console.ReadKey();
        }
    }
}
