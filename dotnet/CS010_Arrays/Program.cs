using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS010_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Se asigna directo
            int[] tabla1 = new int[100];

            // Se declara y asigna por separado
            int[] tabla2;
            tabla2 = new int[100];

            // El tamaño se asigna en base a los valores dados
            int[] tabla3 = new int[] { 5, 1, 4, 0 };

            // Se define sin usar el tipo de datos
            int[] tabla4 = { 5, 1, 4, 0 };


            // Se asigna dinamicamente el tamaño
            int i = 5;
            int[] tablaDinámica = new int[i];

            // Por defecto se inicializan en cero todos los valores
            int[] tabla = new int[4];
            tabla[0] = 5;

            // De cero pasa a uno
            tabla[1]++;

            // tabla[2] pasa a valer 4, pues 5-4 = 1
            tabla[2] = tabla[0] - tabla[1];
            // El contenido de la tabla será {5,1,4,0}


            // Tablas "dentadas"
            int[][] tablaDentada = { new int[2], new int[3] };
            tablaDentada[1][2] = 10;

            // Tablas multidimensionales
            int[,] tablaMultidimensional1 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] tablaMultidimensional2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };


            /*
             * Como todas las tablas en C# provienen del objeto System.Array
             * las variables declaradas tienen a su disposición los siguien-
             * tes metodos/propiedades:
             * 
             * Lenght: Longitud de la tabla
             * Rank:   Numero de dimensiones de la tabla
             * CopyTo: Copia elementos de un arreglo en otra variable
             * 
             */
        }
    }
}
