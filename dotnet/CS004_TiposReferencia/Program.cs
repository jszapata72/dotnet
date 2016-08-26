
/* OCT/2015
 * 
 * Para "declarar" variables "tipo referencia" se usan las sg.
 * palabras clave en C#:
 * + class
 * + interface
 * + delegate
 * 
 * Estos elementos son los mas usados en el lenguaje, de hecho
 * la mayoría de los elementos (objetos, librerías...) dentro-
 * del framework .Net son tipo referencia.
 * 
 * Aqui un ejemplo de uso de una variable declarada con el tipo
 * mas basico, el tipo "object". Y el uso de los tres metodos-
 * heredados de este...
 * 
 */

using System;

namespace CS004_TiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            object b = new object();
            Console.WriteLine("GetHashCode = {0}", b.GetHashCode());
            Console.WriteLine("GetType = {0}", b.GetType());
            Console.WriteLine("ToString = {0}", b.ToString());

            /* Boxing/Unboxing:
             * Se refiere al hecho de convertir variables "Tipo Valor" en
             * variables "Tipo Referencia" o viceversa.
             * 
             */
            int numero = 5;
            object rNumero;

            rNumero = numero;  // boxing
            Console.WriteLine(rNumero);
            rNumero = 10;
            numero = (int)rNumero;  // unboxing

            Console.WriteLine(numero);
            Console.WriteLine(rNumero);

            Console.ReadKey(true);
        }
    }
}
