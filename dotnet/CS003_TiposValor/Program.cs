/* OCT/2015
 * 
 * Tomado de la documentación oficial:
 * Hay dos clases de tipos de C#: tipos referencia y tipos valor
 * Las variables de tipos referencia almacenan referencias a sus 
 * datos (objectos), mientras que las variables de tipos de valor 
 * contienen directamente los datos.  Con los tipos referencia, 
 * dos variables pueden hacer referencia al mismo objeto; por 
 * consiguiente, las operaciones en una variable pueden afectar al 
 * objeto referenciado por otra variable. Con tipos de valor, cada
 * variable tiene su propia copia de los datos, y no es posible 
 * que las operaciones en una variable afectan a otra...
 * 
 * 
 * Hay algo que todavia no entiendo bien del framework .Net se
 * supone que todo es un objeto y los objetos por definición 
 * son tipos de referencia... y resulta que si hay tipos de --
 * datos que son "de valor".
 * 
 * 
 * Bueno, a ver si voy entendiendo un poco esto (basado en lo-
 * que acabo de leer).
 * 
 * Tipos de valor:
 * + Enteros (byte, sbyte, char, short, int, Lont, etc.)
 * + Punto flotante (float, double)
 * + bool
 * + Estructuras (mas adelante veremos ejemplos)
 * + Enumeraciones (mas adelante veremos ejemplos)
 *
 * ===========================================================
 * TODOS ESTOS, PROVIENEN O SON DEL TIPO "System.ValueType"
 * (A DIFERENCIA DE LOS "Tipos de referencia" QUE PROVIENEN
 *  DEL TIPO "System.Object).
 * ===========================================================
 * 
 * En estos tipos de datos cuando se copia (asigna o usa) una-
 * variable de este tipo, se copia el valor contenido. Esto es
 * mas rapido que trabajar con objetos.
 * 
 * Otra cosa, las variables de este tipo no pueden tener el --
 * valor nulo (null), ya que no son objetos. De hecho cuando -
 * se declara una variable de este tipo, el compilador le ----
 * asigna automaticamente un valor (distinto de nulo).
 * 
 * Pero (algo que se me hace raro, bastanta raro), los tipo de
 * valor, se pueden declarar como si fuera un objeto (de hecho
 * ya dije que "descienden" de System.ValueType, y como tal, -
 * heredan los metodos basicos de este tipo... asi que podemos
 * ver algo como esto:
 *    int i = new int();
 * 
 * Y el compilador le asigna un valor inicial, dependiendo del
 * tipo de dato que sea.
 * 
 */

using System;

namespace CS03_TiposValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("i = {0}", i);

            // ERROR: no se puede asignar null a una variable "tipo valor"
            //int j = null;

            // Copia datos directamente
            int a = i;

            // Asignación automatica (asigna cero a la variable b)
            int b = new int();
            Console.WriteLine("b = {0}", b);

            Console.ReadKey(true);
        }
    }
}
