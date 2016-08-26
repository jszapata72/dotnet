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
            // Numeros
            int i = 10;
            decimal d = 10.236M;

            Console.WriteLine(string.Format("{0:000}", i)); // 010
            Console.WriteLine(string.Format("{0:###}", i)); // 10
            Console.WriteLine(string.Format("{0:###.00}", d)); // 10.24
            Console.WriteLine(string.Format("{0:###.000}", d)); // 10.236
            Console.WriteLine(string.Format("{0:F3}", d)); // 10.236

            Console.ReadKey();
        }
    }
}
