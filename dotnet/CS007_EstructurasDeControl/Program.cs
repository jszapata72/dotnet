/*
 * JUN/2016:Juan Antonio Sandoval Zapata
 * 
 * Estructuras de control:
 * 
 * 1: if (condición) sentencia;
 *    donde "condición" debe ser cualquier expresión boleana
 *    y "sentencia" puede ser un bloque de instrucciones ---
 *    encerrados entre llaves.
 *    
 *    Operadores de relación:
 *    <
 *    >
 *    <=
 *    >=
 *    ==
 *    !=
 *    Is
 *    As
 *    
 *    Operadores lógicos:
 *    &&         AND
 *    ||         OR
 *    ^          XOR
 *    &          AND bit/bit (no hace un "corto-circuito")
 *    |          OR  bit/bit (no hace un "corto-circuito")
 *    x??y       Devuelve "y" si "x" es null
 *    t?x:y      si la prueba t es true, evalúa y devuelve x; en caso contrario, evalúa y devuelve y
 * 
 */

using System;

namespace CS007_EstructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF
            int a = 10;
            int b = 50;
            if (a > b)
                Console.WriteLine("A es mayor que B");
            if (a < b)
                Console.WriteLine("A es menor que B");
            if (a == b)
                Console.WriteLine("A y B son iguales");
            if (a > 0 && b > 0)
                Console.WriteLine("Ambos numeros son positivos");



            // ? (Si a es mayor que b, entonces asigna a. En caso contrario asigna b)
            int numeroMayor = (a > b) ? a : b;


            // Switch
            char letra = '0';
            switch (letra)
            {
                case ' ':
                    Console.WriteLine("Espacio.");
                    break;

                case '1': goto case '0';
                case '2': goto case '0';
                case '3': goto case '0';
                case '4': goto case '0';
                case '5': goto case '0';
                case '6': goto case '0';
                case '7': goto case '0';
                case '8': goto case '0';
                case '9': goto case '0';

                case '0':
                    Console.WriteLine("Dígito.");
                    break;

                default:
                    Console.WriteLine("Ni espacio ni dígito.");
                    break;
            }

            letra = 'Z';
            switch (letra)
            {
                case ' ':
                    Console.WriteLine("Espacio.");
                    break;

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("Dígito.");
                    break;

                default:
                    Console.WriteLine("Ni espacio ni dígito.");
                    break;
            }



            Console.ReadLine();
        }
    }
}
