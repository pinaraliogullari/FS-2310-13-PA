using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Proje06_MvcWithSql.Dal
{
    public static class Db
    {

        public static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection()
        {
            string connectionString = @"Server=DESKTOP-QE6JDF1\SQLEXPRESS;Database=Northwind;user Id=sa; password=pe969416; TrustServerCertificate=true";
            return new SqlConnection(connectionString);
        }

        public static void OpenCn()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                Console.WriteLine("Bağlantı başarıyla kuruldu.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void CloseCn()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}