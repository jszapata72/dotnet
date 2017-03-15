using System;
using Microsoft.Data.Sqlite;

namespace CS110_BD_SQLITE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sqlite = new SqliteConnection(
                @"Data Source=c:/sistema/data/dbsample.sqlite");
            Console.WriteLine(sqlite.State);
            sqlite.Open();
            Console.WriteLine(sqlite.State);
            sqlite.Close();
            Console.WriteLine(sqlite.State);

            Console.ReadLine();
        }
    }
}
