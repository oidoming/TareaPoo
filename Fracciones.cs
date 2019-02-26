using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public Fraccion()
        {
            numerador = 1;
            denominador = 1;
        }

        public static Fraccion operator +(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.numerador * y.denominador + x.denominador * y.numerador, x.denominador * y.denominador);
            return
                result;
        }

        public static Fraccion operator -(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.numerador * y.denominador - x.denominador * y.numerador, x.denominador * y.denominador);
            return
                result;
        }

        public static Fraccion operator *(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.numerador * y.numerador, x.denominador * y.denominador);
            return
                result;
        }

        public void Imprime()
        {
            Console.WriteLine("{0}/{1}", numerador, denominador);
        }

        public decimal a_decimal()
        {
            return numerador / denominador;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraccion a = new Fraccion(1,2);
            Fraccion b = new Fraccion();
            Fraccion c = a + b;
            Fraccion d = a - b;
            Fraccion e = a * b;
            a.Imprime();
            b.Imprime();
            c.Imprime();
            d.Imprime();
            e.Imprime();

            Console.ReadKey();
        }
    }
}
