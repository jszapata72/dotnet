using System;
using System.Linq;
using System.Collections.Generic;

namespace CS_106_Colecciones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Lista
            List<string> mc = new List<string>();
            mc.Add("Hola Mundo");
            string s = mc[0];
            Console.WriteLine(s);

            mc.Clear();
            mc.Add("Uno");
            mc.Add("Dos");
            mc.Add("Tres");
            mc.Add("Cuatro");
            foreach (string str in mc)
            {
                Console.WriteLine(str);
            }
            mc.Sort();


            // Pila
            Stack<string> st = new Stack<string>();
            st.Push("Uno");
            st.Push("Dos");
            st.Push("Tres");
            st.Push("Cuatro");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(st.Pop());
            }


            // Lista, con valores iniciales
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    numbers.RemoveAt(index);
                }
            }


            // Lista de objetos
            List<Point> puntos = new List<Point>
            {
                new Point() { x=1, y=10.1M },
                new Point() { x=2, y=9.2M },
                new Point() { x=3 },
                new Point() { x=4 }
            };

            foreach (Point p in puntos)
            {
                Console.WriteLine(p);
            }

            /* Anexo :)... (coqueteando con LINQ)
             * Obtengo un "subconjunto" de la lista que cumpla con la condición
             * declarada en el "where" y ordenado segun el campo del "orderby".
             * 
             */
            var sub = from e in puntos
                      where e.x <= 2  // && e.y=0
                      orderby e.x descending, e.y ascending
                      select e;
            foreach (Point e in sub)
            {
                Console.WriteLine("LINQ {0}", e);
            }


            // Diccionarios (clave/valor)
            Dictionary<int, string> d = new Dictionary<int, string>()
            {
                { 1, "Uno" },
                { 2, "Dos" },
                { 3, "Tres" }
            };
            foreach (KeyValuePair<int, string> k in d)
            {
                Console.WriteLine("Key={0}, Value={1}, k={2}", k.Key, k.Value, k.ToString());
            }
            d.Add(4, "Cuatro");
            foreach (KeyValuePair<int, string> k in d)
            {
                Console.WriteLine("Key={0}, Value={1}, k={2}", k.Key, k.Value, k.ToString());
            }


            Console.ReadLine();
        }
    }


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
        public override string ToString()
        {
            return string.Format("({0},{1})", this.x, this.y);
        }
    }
}
