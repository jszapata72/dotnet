using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace CS107_BD_MSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ConnectionString
            var cx = new MySqlConnection(
                "Server=192.168.1.10; Database=gfiles; user id=sandoval; password=292006"
            );


            // Me conecto
            Console.WriteLine(cx.State);
            cx.Open();
            Console.WriteLine(cx.State);


            // Ejecuto una consulta
            var cmd = new MySqlCommand();
            cmd.Connection = cx;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"
            select n_serie, fecha
              from gfiles
             limit 10
            ";

            using (var rd = cmd.ExecuteReader())
            {
                // campos
                var fields = new string[rd.FieldCount];
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    Console.WriteLine("{0}\t{1}\t{2}"
                    , rd.GetName(i)   // Nombre del campo
                    , rd.GetFieldType(i)   // Tipo de datos .net
                    , rd.GetDataTypeName(i)  // Tipo de datos mssql
                    );

                }


                // datos
                while (rd.Read())
                {
                    Console.WriteLine();
                    for (int i = 0; i < rd.FieldCount; i++)
                    {
                        Console.Write("{0}\t", rd.GetValue(i));
                    }
                }
            }


            // Me desconecto
            cx.Close();
            Console.WriteLine(cx.State);
            Console.ReadLine();
        }
    }
}
