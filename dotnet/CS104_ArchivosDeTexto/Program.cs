using System;
using System.IO;

namespace CS_104_ArchivosDeTexto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region "StreamWriter"
            /* ESCRITURA:
             * Igual que en la lectura... :), ske empeze por la  lectura
             * Lo unico que cambia es que aqui vamos a escribir datos en
             * el archivo de texto.
             *
             */
            string nombreArchivo = "c:/sistema/temp/ArchivoTexo.txt";
            var sw = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.Write);
            using (var writer = new StreamWriter(sw))
            {
                writer.Write("Uno");
                writer.WriteLine("Dos");
                writer.WriteLine("Tres");
            }
            #endregion


            #region "StreamReader"
            /* LECTURA:
             * 
             * Para la lectura de un archivo de texto primero debo obtener
             * un "stream" esto se logra con el  metodo  "FileStream" y se 
             * le pasa como parametros:
             *   1. El nombre del archivo
             *   2. El modo de apertura (Read, Write, etc.)
             *   3. El modo de "compartición" -que fea palabra-
             *   
             * Una vez obtenido el  "stream" se abre el archivo con el ---
             * objeto "StreamReader" el cual permite leer los datos del --
             * archivo.
             * Tenemos varios metodos para lograr esto, en el ejemplo se -
             * esta usando "ReadLine" el cual permite extraer la siguiente
             * linea, esto hasta que se llegue al final del archivo.
             * 
             */
            var sr = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.Read);
            using (var reader = new StreamReader(sr))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            #endregion


            // Fin :)
            System.Threading.Thread.Sleep(3000);
        }
    }
}
