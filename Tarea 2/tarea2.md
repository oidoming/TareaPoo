# Unidad 2. Clases y Objetos
## 2.1 Declaración de clases: atributos, métodos, encapsulamiento.
Las clases y estructuras son bloques de codigo para separarse y encapsularse.
## 2.2 Instanciación de una clase.
El operador new sirve para crear objetos e iniciar un cosntructor.  
Tambien se utiliza para crear instancias de tipo anonimos. El operador new también se utiliza para invocar el constructor predeterminado para los tipos de valor.
## 2.3 Referencia al objeto actual.
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
Los constructores son métodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado. Los constructores tienen el mismo nombre que la clase y, normalmente, inicializan los miembros de datos del nuevo objeto.
##  2.6 Sobrecarga de métodos
##  2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.