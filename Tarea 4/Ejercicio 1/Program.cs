using System;

namespace Ejercicio_1
{
    class A
    {
        public int a;

        public A()
        {
            a = 10;
        }

        public string Display()
        {
            return a.ToString();
        }
    }

    class B:A
    {
        public int b;

        public B():base()
        {
            b = 15;
        }

        public new string Display()
        {
            return b.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();

            B objB = new B();

            Console.WriteLine(objA.Display()); 

            Console.WriteLine(objB.Display());

            Console.ReadKey();
        }
    }
}
