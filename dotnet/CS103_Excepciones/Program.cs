using System;

namespace CS_103_Excepciones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            try
            {
                Console.WriteLine("Introduzca el primer numero");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 / numero2;
                Console.WriteLine("Su división es: {0}", resultado);
            }
            catch (FormatException)  // Error de formato (no es un numero)
            {
                Console.WriteLine("No es un número válido");
            }
            catch (DivideByZeroException)  // Error de división x cero
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            catch (Exception e)  // Cualquier otro error
            {
                Console.WriteLine("Ha habido un error: {0}", e.Message.ToUpper());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
