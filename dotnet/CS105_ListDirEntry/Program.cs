using System;
using System.IO;

namespace CS_105_ListarElementosDirectorio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo("c:/sistema");
                FileInfo[] files = directory.GetFiles("*.*");
                DirectoryInfo[] directories = directory.GetDirectories();

                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(((FileInfo)files[i]).FullName);
                }

                for (int i = 0; i < directories.Length; i++)
                {
                    Console.WriteLine(((DirectoryInfo)directories[i]).FullName);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Fin :)
            System.Threading.Thread.Sleep(3000);
        }
    }
}
