using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS009_FormatoCadenas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Numeros
             * 
             */
            int i = 10;
            int i2 = 100;
            int i3 = 1000;
            decimal d = 10.236M;
            decimal d2 = 9.21M;
            decimal d3 = 0.1M;
            decimal d4 = 236426.35M;

            Console.WriteLine(string.Format("{0:0000}", i));    // 0010
            Console.WriteLine(string.Format("{0:###}", i));     // 10
            Console.WriteLine(string.Format("{0:###.00}", d));  // 10.24
            Console.WriteLine(string.Format("{0:###.000}", d)); // 10.236
            Console.WriteLine(string.Format("{0:F3}", d));      // 10.236

            // Alineación a la derecha
            Console.WriteLine(string.Format("{0,6}", i));   //    10
            Console.WriteLine(string.Format("{0,6}", i2));  //   100
            Console.WriteLine(string.Format("{0,6}", i3));  //  1000
            
            // Alineación a la izquierda
            Console.WriteLine(string.Format("{0,-6}", i));   //  10
            Console.WriteLine(string.Format("{0,-6}", i2));  //  100
            Console.WriteLine(string.Format("{0,-6}", i3));  //  1000

            // Longitud de 8, con 2 decimales
            Console.WriteLine(string.Format("{0,8:F2}", d));  //  10.24
            Console.WriteLine(string.Format("{0,8:F2}", d2)); //   9.21
            Console.WriteLine(string.Format("{0,8:F2}", d3)); //   0.10

            // Monetario
            Console.WriteLine(string.Format("{0,12:N2}", d4));  //  236,426.35


            /*
             * Fechas:
             * ================================================
             * d        Dia del mes (1-31)
             * dd       Dia del mes (01-31)
             * ddd      Dia de la semana (nombre corto, Mon)
             * dddd     Dia de la semana (nombre largo, Monday)
             * 
             * g        Periodo o era (A.C.)
             * 
             * h        Hora (1-12)
             * hh       Hora (01-12)
             * H        Hora (1-24)
             * HH       Hora (02-24)
             * 
             * m        Minutos (0-59)
             * mm       Minutos (00-59)
             * 
             * s        Segundos (0-59)
             * ss       Segundos (00-59)
             * 
             * tt       AM/PM
             * 
             * M        Mes (1-31)
             * MM       Mes (01-31)
             * MMM      Nombre corto, Jun
             * MMMM     Nombre largo, June
             * 
             * y        Año (0-99)
             * yy       Año (00-99)
             * yyyy     Año
             * 
             * f        Decimas de segundo
             * ff       Centesimas de segundo
             * fff      Milisegundos
             * 
             * K        Zona horaria
             * 
             */
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"));
            Console.WriteLine("Mes: {0}", DateTime.Now.ToString("MMMM"));
            Console.WriteLine("Mes: {0}", DateTime.Now.ToString("MMM"));

            Console.ReadKey();
        }
    }
}
