# Unidad 1: Introducción al paradigma de la programación orientado a objetos
### 1. Paradigma
Es la manera en que se programa en cada lenguaje de programacion.
### 2. Abstracción, da dos ejemplos.
La abstraccion sirve para definir una clase, las caracteristicas de la clase (atributos) sin especificar.  
Ejemplo 1: Caundo mensionan edificio cada persona tiene una manera distinta de imaginarlo, sin embargo, los edificios tienen cosas en comun como las ventnas, tamano, color, etc. y al imaginarlo se hara con esos atributos pero de dsitintos tipos.  
Ejemplo 2: Al imaginar un pez sabemos lo que hace (comer, nadar, respirar), no hace falta  dar detalles.
### 3. ¿Por qué decimos que la Clase es el mecanismo de abstracción de los lenguajes OO?
Porque es la manera de poner atributos y definirlos en cada clase.
### 4. Explica el concepto de encapsulamiento, busca dos imágenes que te ayuden a describir el concepto, una que tenga algún sistema sin encapsulamiento y otra donde si lo tenga. Menciona por que es importante y que problemas puede evitar. 
El encapsulamiento es la forma de ocultar nuestros metodos, atributos de nustra clase para limitar la accesibilidad.
```csharp
//Con encapsulamiento
   public class a
    {
        private int precio;
    }
```
```csharp
//Sin encapsulamiento
    class a
    {
        int precio;
    }
```
### 5. Describe con tus palabras el concepto de herencia e ilustra el concepto con imágenes.
La herencia es la reutilizacion de atributos de una clase para implementarlo en otras.  

La clase felino tiene atributos como dientes, cola, forma del pelaje, garras, etc.
![Felino!](https://image.flaticon.com/icons/png/512/47/47403.png)  

De la clase felino podemos sacar la clase gato, que es un tipo de felino que hereda atributos de los felinos en general.
![Gato](https://cdn5.dibujos.net/dibujos/pintados/201120/178e528b3a5cbe20b5abfcdb08c71197.png)
## UML: diagrama de clases.
### 1. Investiga la historia y haz un resumen del Lenguaje de Modelado Unificado, donde se mencione: quienes son sus principales autores (Booch, Rumbaugh, Jacobson), en que tipo de sistemas se utiliza, en particular el Diagrama de Clases. Menciona algunas de las herramientas para el modelado en UML. ¿Sabes de alguna empresa local que utilice este lenguaje? 
El Lenguaje de Modelado Unificado (UML) es un lenguaje estándar para escribir planos de software, UML se puede utilizar para visualizar, especificar, construir y documentar los artefactos de un sistema que involucra una gran cantidad de software. UML prescribe un conjunto de notaciones y diagramas estándar para modelar sistemas orientados a objetos, y describe la semántica esencial de lo que estos diagramas y símbolos significan.

UML es una consolidación de muchas de las notaciones y conceptos más usados orientados a objetos.  Empezó  como  una  consolidación  del  trabajo  de  Grade Booch, James Rumbaugh, e Ivar Jacobson, creadores de tres de las metodologías orientadas  a  objetos  más  populares,  en  1996,  el  Object  Management  Group (OMG), publicó una petición con propósito de un metamodelo orientado a objetos de semántica y notación estándares. UML, en su versión 1.0, fue propuesto como una respuesta a esta petición en enero de 1997.

UML se puede usar para modelar distintos tipos de sistemas como por ejemplo: sistemas de software, sistemas de hardware, y organizaciones del mundo real. UML ofrece nueve diagramas en los cuales modelar sistemas. Es un lenguaje muy expresivo,  que  cubre  todas  las  vistas  necesarias  para  desarrollar  y  luego desplegar tales sistemas.  

El diagrama de clases es un tipo de diagrama de estructura estática que describe la estructura de un sistema mostrando las clases del sistema, sus atributos, operaciones (o métodos), y las relaciones entre los objetos.  

Algunas herramientas para el modelado UML son: MagicDraw, Papyrus UML, Modelio, ArgoUML, StarUML.
### ¿Sabes de alguna empresa local que utilice este lenguaje?
No
### 2. Escribe una propuesta de una máquina que venda distintos artículos y haz el diagrama de clases del sistema que propones. 
