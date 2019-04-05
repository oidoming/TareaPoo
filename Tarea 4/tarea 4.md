## **Tarea 4**
## 1. Considera el siguiente fragmento de programa:
```csharp

   using System;

    class A
    {
        public int a;

        public A()
        {
            a = 10;
        }

        public _______ string Display()
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

    // #########################################

    //  #  Después de contestar la pregunta 1                  

    //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.

    //  #########################################

    }

    class Program
    {
        public static void Main()
        {

            A objA = new A();

            B objB = new B();

            Console.WriteLine(objA.Display()); ////  (1 )

            Console. WriteLine(objB.Display()); ////  ( 2)
        }

    }
```
## 1.1. ¿Qué valores imprimen las lineas (1) y (2) ?
#### Ambas imprimen 10
## 1.2.  Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?.
#### En la linea 1 imprime 10 y en la 2 imprime 15
## 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
#### new
## 2. Considera el siguiente fragmento de programa:
```csharp
using System;
using System.Collections.Generic;

    ________ class Musico
    {
        public string nombre;

        public Musico (string n)
        {
            nombre = n;
        }

        public abstract (A) void Afina();  (B)

         public (C) string Display()

        { 
            return nombre;
        }
    }

    class Bajista; Musico
    {

        public string instrumento;

        public Bajista (string n, string i ) ......

    .........

        public _________ Afina()
        {
        ________________
        }
    }

    class Guitarrista ____________
    {

        public instrumento;

      // Falta el constructor y otras cosas??
    }

 
class Program
{
    public static Main()
    {

        Musico m = new Musico("Django"); (D)

        Bajista b = new Bajista("Flea");

        Guitarrista g = new Guitarrista("Santana");

        Musico [] m = ____________________

        m[0] = b;

        m[1] = g;

        foreach ( ___________)

        _____________________

        Console.ReadKey();
    }
}

```
## 2.1. Completa el programa.
## 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
#### En el punto D esta el error porque no se puede instanciar la clase base abstracta.
## 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
#### El metodo afina para hacer que retorne una opcion diferente.
## 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
#### Porque es un metodo abstracto, solo se ponen en los metodos comunes o virtuales.
## 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
#### Tendriamos que poner llaves y quitar el punto y coma.
## 3. Implementa el programa utilizando interfaces en lugar de herencia.