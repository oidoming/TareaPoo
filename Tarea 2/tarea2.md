# Unidad 2. Clases y Objetos
## 2.1 Declaración de clases: atributos, métodos, encapsulamiento.
Las clases y estructuras son bloques de codigo para separarse. Las estructuras van dentro de la clase y sirven para crear cosntructores o inicializar objetos.  
Una class es un tipo de referencia.  
Una estructura es un tipo de valor.
## 2.2 Instanciación de una clase.
El operador new sirve para crear objetos e iniciar un cosntructor.  
Tambien se utiliza para crear instancias de tipo anonimos. El operador new también se utiliza para invocar el constructor predeterminado para los tipos de valor.
## 2.3 Referencia al objeto actual.
Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.
``` csharp
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
```  
Escribe un programa donde se utilice this como parámetro.
``` csharp 
using System;

namespace _2._3
{
    public class Persona 
    {
        private int edad;

        public Persona(int edad)
        {
              this.valor=valor
        } 

        public Persona()
        {
              this(32);
        } 
      }

    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
```
## 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
### Parámetros de métodos
Es una declaracion de variables.  
Si se usa palabras clave de parámetros de método en la declaración del parámetro, puede modificar este comportamiento.
### Params
especifica que este parámetro puede tomar un número variable de argumentos.
### out
especifica que este parámetro se pasa por referencia y se escribe mediante el método llamado.
### ref
especifica que este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.
##  2.5 Constructores y destructores: declaración, uso y aplicaciones.
Los constructores son métodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado. Los constructores tienen el mismo nombre que la clase y, normalmente, inicializan los miembros de datos del nuevo objeto. Los cosntructores que no toman algun parametro se denominan constructor predeterminado. Los constructores predeterminados se invocan cada vez que se crea una instancia de un objeto mediante el operador new y no se proporciona ningún argumento a new (Objeto a = new Objeto();).  
Los constructores se pueden marcar como public, private, protected, internal o protectedinternal. Tambien se puede declarar como estático mediante la palabra clave static. 
##  2.6 Sobrecarga de métodos
##  2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.