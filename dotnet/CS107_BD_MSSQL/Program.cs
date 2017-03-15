using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CS107_BD_MSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ConnectionString
            var sb = new SqlConnectionStringBuilder();
            sb.DataSource = "192.168.10.17";
            sb.InitialCatalog = "GFILES";
            sb.IntegratedSecurity = false;
            sb.UserID = "sa_tmp";
            sb.Password = "inmagusa2010";

            
            // Me conecto
            SqlConnection cx = new SqlConnection();
            cx.ConnectionString = sb.ConnectionString;
            cx.Open();
            Console.WriteLine(cx.State.ToString());


            // Ejecuto una consulta
            var cmd = new SqlCommand();
            cmd.Connection = cx;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"
            select top 10 n_serie, fecha
              from ti.dbo.tbPUN_FDATPUN
            order by fecha desc
            ";

            using (var rd = cmd.ExecuteReader())
            {
                // campos
                var fields = new string[rd.FieldCount];
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    Console.WriteLine("{0}\t{1}\t{2}"
                    ,rd.GetName(i)   // Nombre del campo
                    ,rd.GetFieldType(i)   // Tipo de datos .net
                    ,rd.GetDataTypeName(i)  // Tipo de datos mssql
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
            Console.ReadLine();
        }
    }
}
