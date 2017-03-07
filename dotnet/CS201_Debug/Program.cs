using System.Diagnostics;

namespace CSA001_Debug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Muestra texto
            Debug.WriteLine("Init");
            Debug.WriteLine("Primer linea");
            Debug.WriteLine("Segunda linea");

            // Ejecutar solo si esta en modod DEBUG
#if DEBUG
            Debug.Assert(false, "OK");
#endif

            // Lanza debugger
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }

            // Crea punto de interrupcion en base a una condición
            if (true)
            {
                Debugger.Break();
            }

            // Fin :)
            Debug.WriteLine("End");
        }
    }
}
