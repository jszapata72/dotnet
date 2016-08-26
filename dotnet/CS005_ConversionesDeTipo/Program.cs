/*
 * Conversión de tipos: 
 * 
 * 
 * Una conversión de tipos puede ser implicita o explicita.
 * Implicita:   Ocurren automáticamente
 *              Siempre tienen éxito
 *              No se pierde información
 *              
 * Explicita:   Requieren un casting
 *              Pueden fallar
 *              Se puede perder información
 * 
 *              
 * 
 */

using System;

namespace CS005_ConversionesDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Impicitas/Explicitas
            int x = 123456;
            long y = x;            // implicita
            short z = (short)x;    // explicita (riesgo)

            float f1 = 40.0F;
            long l1 = (long)f1;    // explicita (riesgo por redondeo)
            short s1 = (short)l1;  // explicita (riesgo por desbordamiento)
            int i1 = s1;           // implicita, no hay riesgo
            uint i2 = (uint)i1;    // explicita (riesgo de error por signo)

            // Todos los tipos numericos tienen el metodo "parse"
            float f3 = float.Parse("33.678");
            double d3 = double.Parse("33.687");
            int i3 = int.Parse("300");

            // Tambien existe el metodo "Convert"
            double d4 = Convert.ToDouble("100.102");
            long l4 = Convert.ToInt32(100);
            string s4 = Convert.ToString(d4);
        }
    }
}
