
/* OCT/2015
 * 
 * Estos son algunos de los operadores usados en C#:
 * 
 * Operador     Descripción
 * ==============================================================
 *  =           Asignación
 *  +           Suma
 *  -           Resta
 *  *           Multiplicación
 *  /           División
 *  %           Resto (modulo divisor)
 *  ++var       Preincremento
 *  --var       Predecremento
 *  var++       Postincremento
 *  var--       Postdecremento
 *  
 *  x += y      x = x + y
 *  x -= y      x = x - y
 *  x *= y      x = x * y
 *  x /= y      x = x / y
 *  x %= y      x = x % y
 *  
 * 
 * 
 * Expresiones (segun la documentación oficial):
 * Una expresión es una secuencia de uno o más operandos y cero o 
 * más operadores que se pueden evaluar como un valor, objeto, 
 * método o espacio de nombres único.  Las expresiones pueden 
 * constar de un valor literal, una invocación de método, un 
 * operador y sus operandos o un nombre simple. Los nombres 
 * simples pueden ser el nombre de una variable, miembro de tipo, 
 * parámetro de método, espacio de nombres o tipo
 * 
 * 
 * Pues eso :)... las expresiones es una combinación de literales
 * operadores, variables, funciones, etc., cuya combinación nos
 * da como resultado un valor.
 * Las expresiones mas comunes son las artimeticas, por lo que voy
 * a poner algunos ejemplos de estas.
 * 
 */

using System;

namespace C006_Operadores_Expresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            int r1;
            float r2;

            /* 
             * notese que tengo que especificar en la expresión
             * que convierta el resultado a "float". Si no lo -
             * hacemos de esta manera, al ser a y b enteros, la
             * operación la regresa como entero.
             * 
             */
            r1 = a / b;
            r2 = (float)a / b;
            Console.WriteLine("r1 = {0}", r1);
            Console.WriteLine("r2 = {0}", r2);

            // Valores hexadecimales
            int h = 0xff;
            Console.WriteLine("h = {0}", h);

            // Cadenas
            string s = "Juan Antonio";
            Console.WriteLine(s);

            // Caracteres
            char c = 'x';
            Console.WriteLine(c);

            // Asignaciones multiples
            int d;
            a = b = d = 1;

            Console.ReadKey(true);
        }
    }
}
