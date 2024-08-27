using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class Connection
    {
        public static MySqlConnection connection()
        {
            // Definición de parámetros para conexión con BD
            string server = "localhost";
            string db = "school";
            string user = "root";
            string pass = "";

            // Cadena de conexión a DB
            string connectionString = "Database = " + db + ";" +
                "Data Source = " + server + ";" +
                "User Id = " + user + ";" +
                "Password = " + pass + "";
            // Intento de conexión
            try
            {
                MySqlConnection DBconnection = new MySqlConnection(connectionString);
                return DBconnection;
            }
            catch (MySqlException e)
            {
                Console.Write("Error: " + e.Message);
                return null;
            }
        }
    }
}
