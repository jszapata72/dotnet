using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace CS109_BD_PS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cx = new Npgsql.NpgsqlConnection(
                "Server=192.168.12.28; Port=5432; User Id=; Password=; Database=; Timeout=10"
                );
            Console.WriteLine(cx.State);
            cx.Open();
            Console.WriteLine(cx.State);
            cx.Close();
            Console.WriteLine(cx.State);
        }
    }
}
