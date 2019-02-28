using System;

namespace _2._3
{
    class Persona
    {
        public int edad = 29;

        public void Imprimir(int edad)
        {
            Console.WriteLine("Edad = " + this.edad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Imprimir(45);
            
        }
    }
}
