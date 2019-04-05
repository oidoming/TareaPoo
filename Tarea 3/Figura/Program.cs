using System;
using System.Collections.Generic;

namespace Figura
{
    class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    abstract class Figura
    {
        public Vector2d position;
        public string fill ,border;

          //Constructor por defecto 
        public Figura():this( new Vector2d(200, 200))
        {
        
        }
        //constructor de figura
        public Figura(Vector2d pos)
        {
            position= pos;
            fill= "white";
            border= "black";
        }

        public virtual void Dibuja()
        {
            
        }
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Color a = new Color();
        
        Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, a.getColor());
     }
    }
 
    class Rectangulo : Figura
    {
        private int base1;
        private int altura;
     public Rectangulo(Vector2d pos, int base1, int altura):base(pos)
     {
         this.base1 = base1;
         this.altura = altura;
     }
     public Rectangulo ():base()
     {
        this.base1 = 10;
        this.altura = 20;
     }   
    }

    class Cuadrado : Figura
    {
        private int altura, base1;
     public Cuadrado(Vector2d pos, int altura, int base1):base(pos)
     {
         this.altura= altura;
         this.base1 = base1;
     }
     public Cuadrado():base()
     {
         this.altura = 20;
         this.base1 = 20;
     }

     /*public override void Dibuja() 
     {
        
        Color a = new Color();
        a.setColor("Amarillo");
       // Console.WriteLine(a.getColor());
        Console.WriteLine("Se dibuja un cuadrado en {0} de color {1}", position, a.getColor());
     }*/

    }

    class Triangulo : Figura
    {
        private int altura, base1, hipotenusa;
     public Triangulo(Vector2d pos, int altura, int base1, int hipotenusa):base(pos)
     {
         this.altura= altura;
         this.base1 = base1;
         this.hipotenusa = hipotenusa;
     }
     public Triangulo():base()
     {
         this.altura = 20;
         this.base1 = 13;
         this.hipotenusa = 27;
     }

     /*public override void Dibuja() 
     {
        
        Color a = new Color();
        a.setColor("Amarillo");
       // Console.WriteLine(a.getColor());
        Console.WriteLine("Se dibuja un triangulo en {0} de color {1}", position, a.getColor());
     }*/

    }

     class Color
    {
        private string color;

        public Color()
        {
            color = "Gris";
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor(){
            return this.color;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(new Vector2d(500,500), 250));
            figuras.Add(new Rectangulo());
            figuras.Add(new Cuadrado());
            figuras.Add(new Triangulo());
            
            foreach(Figura figura in figuras)
            figura.Dibuja();
        }
    }
}
