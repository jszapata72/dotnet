/* OCT/2015
 * 
 *    En cualquier lenguaje tenemos "tipos de datos" para trabajar--
 * y por supuesto que C# no es la excepción; de hecho el propio .Net
 * tiene un sistema llamado "CTS: Common Type System".
 * El CTS es un conjunto de reglas que deben seguir los lenguajes --
 * que quieran pertenecer al .Net. Esto permite que haya compatibi--
 * lidad entre todos los lenguajes.
 * 
 * Dentro del CTS tenemos los siguientes tipos de datos:
 * 
 * CTS                Alias C#
 * ==============================================================
 * System.Object      object      clase base para todos los tipos
 * System.String      string      cadenas
 * System.SByte       sbyte
 * System.Byte        byte
 * System.Int16       short
 * System.UInt16      ushort
 * System.Int32       int
 * System.UInt32      uint
 * System.Int64       long
 * System.UInt64      ulong
 * System.Char        char        caracter unicode de 16 bits
 * System.Single      float       valor flotante de 32 bits
 * System.Double      double      valor flotante de 64 bits
 * System.Boolean     bool        true/false
 * System.Decimal     decimal     valor de 128 bits
 * 
 * El "alias" se refiere a la manera en que podemos usarla en C#
 * de forma mas corte; esto no quiere decir que no podamos usar
 * el formato del CTS.
 * 
 * 
 * Declarar variables:
 * ===================
 * 1: 'tipo' 'variable'
 * 2: 'tipo' 'lista de variables'
 * 3: 'tipo' 'variable' = 'valor'
 * 
 * 
 * Asignar valores a variables:
 * ============================
 * 'variable' = 'valor'
 *
 * Donde 'valor' puede ser una literal, otra variable o una 
 * expresión completa.
 * 
 * 
 * Literales, ejemplos:
 * ====================
 * Cadenas:    "Hola Mundo"
 * Caracteres: 'h'
 * Numeros:    12, 34L, 64U, 1.23f, 4.56D, 562.3M
 * Booleanos:  true, false
 * 
 * 
 * Expresiones, ejemplos:
 * ======================
 * Voy a poner unos ejemplos de expresiones artimeticas que
 * son las mas usadas:
 * 
 * 1: (1 + 5)/2
 * 2: (a * b) - (3 * 2)
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS002_TiposDeDatos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declaro variables
            int i;
            int b = 0;
            float f = 5.23f;
            bool activar;
            string hola = "Hola Mundo";

            // Asigno valores
            i = (b + 5) - 1;
            activar = true;


            // Muestro datos
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("f = {0}", f);
            Console.WriteLine("activar = {0}", activar);
            Console.WriteLine("hola = {0}", hola);

            // Literales enteras
            int i1 = 0300;        // octal
            int i2 = 0xfff;       // hexadecimal
            uint i3 = 328u;       // unsigned
            long i4 = 0x7FFFFFL;  // long
            ulong i5 = 0776745ul; // unsigned long

            // literales flotantes
            float f1 = 3.1416f;
            double f2 = 3.1416d;
            decimal f3 = 3.1416m;

            // literales de  caracter
            char c1 = 'a';    // el carcater 'a' :)
            char c2 = '\'';   // el caracter comilla simple '
            char c3 = '\"';   // el caracter comilla doble "
            char c4 = '\b';   // retroceso
            char c5 = '\f';   // avance de pagina
            char c6 = '\n';   // nueva linea
            char c7 = '\u005C';   // representa el caracter unicode '\'

            // literales cadenas
            string s1 = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
            string s2 = @"\\server\share\file.txt";      // \\server\share\file.txt
            string s3 = "one\r\ntwo\r\nthree";
            string s4 = @"one
            two
            three";
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            // Lo nuevo...
            // La palabra reservada "var" permite declarar una
            // variable y que el compilador "deduzca" su tipo
            // en base al valor asignado.
            // 
            var x = 234;
            Console.WriteLine("Tipo de x = {0}", x.GetType());

            // Espero a que se pulse una tecla
            Console.ReadKey();
        }
    }
}
