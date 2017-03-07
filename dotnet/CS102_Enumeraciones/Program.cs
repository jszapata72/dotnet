using System;

namespace CS_102_Enumeraciones
{
    enum DiasSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    class Program
    {
        static void Main(string[] args)
        {
            DiasSemana d;
            d = DiasSemana.Jueves;

            if (d == DiasSemana.Domingo)
                Console.WriteLine("A descansar!");

            switch (d)
            {
                case DiasSemana.Lunes:
                    Console.WriteLine("Uf!");
                    break;

                case DiasSemana.Domingo:
                    Console.WriteLine("A descansar!");
                    break;
            }

            Console.WriteLine(d);
            Console.WriteLine(d.ToString());

            // Se obtiene 3 ya que las enumeraciones le asignan un valor a cada elemento, empezando en cero
            Console.WriteLine(Convert.ToInt16(d));
            Console.ReadKey();
        }
    }
}
