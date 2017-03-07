using System;

namespace CS_101_Estructuras
{
    struct Point
    {
        // Campos
        public decimal x, y, z, d;
        public char l;

        // Propiedades
        private char loc;
        public char Loc
        {
            get
            {
                return loc;
            }
            set
            {
                loc = value;
            }
        }

        // Constructor
        public Point(int x)
        {
            this.x = x;
            y = 0;
            z = 0;
            d = 0;
            l = ' ';
            loc = ' ';
        }

        // Funciones/Metodos
        public string getCoord()
        {
            return string.Format("({0},{1})", x, y);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Point p = new Point(0);
            Console.WriteLine(p.getCoord());
            Console.WriteLine(p.y);

            Console.ReadKey(true);
        }
    }
}
