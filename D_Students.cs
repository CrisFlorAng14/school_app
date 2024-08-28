using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    public class D_Students
    {
        public DataTable List_Students(string cText)
        {
            MySqlDataReader students;
            DataTable tableStudents = new DataTable();

            // Añade los comodines % para búsqueda parcial
            cText = "%" + cText + "%";

            using (MySqlConnection conn = ConnectionDB.getInstance().createConnection())
            {
                try
                {
                    string querySelect = "SELECT id AS 'ID', " +
                                         "num_control AS 'MATRÍCULA', " +
                                         "name AS 'NOMBRE', " +
                                         "first_lastname AS 'PATERNO', " +
                                         "second_lastname AS 'MATERNO', " +
                                         "birthdate AS 'NACIMIENTO', " +
                                         "gender AS 'GÉNERO', " +
                                         "email_contact AS 'EMAIL', " +
                                         "phone AS 'TELÉFONO', " +
                                         "address AS 'DIRECCIÓN' " +
                                         "FROM STUDENTS " +  // Espacio añadido aquí
                                         "WHERE name LIKE @search " +
                                         "OR first_lastname LIKE @search " +
                                         "OR second_lastname LIKE @search " +
                                         "OR email_contact LIKE @search " +
                                         "OR phone LIKE @search " +
                                         "OR address LIKE @search";

                    using (MySqlCommand command = new MySqlCommand(querySelect, conn))
                    {
                        // Agregar el parámetro con los comodines de búsqueda
                        command.Parameters.AddWithValue("@search", cText);
                        command.CommandTimeout = 60;

                        conn.Open();
                        students = command.ExecuteReader();
                        tableStudents.Load(students);
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el error para propósitos de depuración o manejo de errores
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return tableStudents;
        }

    }
}
