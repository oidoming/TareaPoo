using System;
using System.Collections.Generic;

namespace Figura2
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
        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        //constructor de figura
        public Figura(Vector2d pos)
        {
            position= pos;
            fill= "white";
            border= "black";
        }

        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Color a = new Color();
        
        Console.WriteLine("Se dibuja un triangulo en {0} de color {1}", position, a.getColor());
     }
    }
 
    class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2d pos):base(pos)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Color a = new Color();
        a.setColor("Rojo");
        Console.WriteLine("Se dibuja un triangulo en {0} de color {1}", position, a.getColor());
     }
    }

    class Triangulo : Figura
    {
        private int altura, base1;
     public Triangulo(Vector2d pos, int altura, int base1):base(pos)
     {
         this.altura= altura;
         this.base1 = base1;
     }
     public Triangulo ():base()
     {
         this.altura= 15;
         this.base1= 8;
     }

     public override void Dibuja() 
     {
        
        Color a = new Color();
        a.setColor("Amarillo");
       // Console.WriteLine(a.getColor());
        Console.WriteLine("Se dibuja un triangulo en {0} de color {1}", position, a.getColor());
     }

    }

     class Color
    {
        private string color;

        public Color()
        {
            color = "Blanco";
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

            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2d(200,200) ));
            figuras.Add(new Triangulo());
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}