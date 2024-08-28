using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace SchoolApp
{
    class ConnectionDB
    {
        private string db;
        private string server;
        private string port;
        private string username;
        private string password;
        private static ConnectionDB conn = null;

        private ConnectionDB()
        {
            this.db = "school";
            this.server = "localhost";
            this.port = "3306";
            this.username = "root";
            this.password = "";
        }

        public MySqlConnection createConnection()
        {
            MySqlConnection stringConn = new MySqlConnection();
            try
            {
                stringConn.ConnectionString = "datasource = " + this.server +
                    "; port = " + this.port +
                    "; username = " + this.username +
                    "; password = " + this.password +
                    "; Database = " + this.db;
            }
            catch (Exception ex)
            {
                stringConn = null;
                throw ex;
            }
            return stringConn;
        }

        public static ConnectionDB getInstance()
        {
            if(conn == null)
            {
                conn = new ConnectionDB();
            }
            return conn;
        }

        

        /**
         * Función para establecer conexión con MySQL
         * Entradas: Ninguna
         * Salidas: Conexión con la BD
         */
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
