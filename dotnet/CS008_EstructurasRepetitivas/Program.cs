/*
 * LOOPS:
 * while (condición)
 *    sentencia(s);
 * 
 * do 
 *    sentencia(s);
 * while (condición);
 * 
 * 
 * for (valorInicial; CondiciónRepetición; Incremento)
 *    sentencia(s);
 * 
 * foreach (variable in )
 * 
 * 
 * break;
 * continue;
 * 
 * goto mas_alla;
 * 
 * mas_alla:
 * 
 */

using System;

namespace CS008_EstructurasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine("i={0}", i);
            }
            Console.WriteLine();


            // do while
            i = 0;
            do
            {
                i++;
                Console.WriteLine("i={0}", i);
            } while (i < 10);
            Console.WriteLine();


            // for
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("i={0}", i);
            }
            Console.WriteLine();


            // break/continue
            i = 0;
            while (i < 10)
            {
                i++;
                if (i == 5) continue;
                if (i == 8) break;
                Console.WriteLine("i={0}", i);
            }
            Console.WriteLine();


            // foreach
            string nombre = "Juan Antonio";
            foreach (char letra in nombre)
            {
                Console.WriteLine(letra);
            }


            // goto
            goto final;
            Console.WriteLine("Esto no sale");

            final:
            Console.ReadLine();
        }
    }
}
