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
        /**
         * Función para mostrar listado de alumnos
         * Entradas: Valor de búsqueda de alumnos
         * Salidas: Registro de alumnos
         */
        public DataTable List_Students(string cText)
        {
            MySqlDataReader students; // Lector SQL para estudiantes
            DataTable tableStudents = new DataTable(); // Componente de tabla de datos

            // Comodines % para búsqueda parcial
            cText = "%" + cText + "%";

            // Obtener la conexión a la BD
            using (MySqlConnection conn = ConnectionDB.getInstance().createConnection())
            {
                try
                {
                    // Comando SQL para consulta de datos
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
                                         "FROM STUDENTS " + 
                                         "WHERE name LIKE @search " +
                                         "OR first_lastname LIKE @search " +
                                         "OR second_lastname LIKE @search " +
                                         "OR email_contact LIKE @search " +
                                         "OR phone LIKE @search " +
                                         "OR address LIKE @search";
                    // Establecer y ejectar el comando con la conexión a la BD
                    using (MySqlCommand command = new MySqlCommand(querySelect, conn))
                    {
                        // Parámetro con los comodines de búsqueda
                        command.Parameters.AddWithValue("@search", cText);
                        command.CommandTimeout = 60; // Establecer el tiempo de 
                        conn.Open(); // Abrir la conexión
                        students = command.ExecuteReader(); // Ejecutar comando de consulta
                        tableStudents.Load(students); // Cargar los datos a la tabla
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally // En cualquier caso: Cerrar la conexión si está abierta
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            // Retornar la tabla
            return tableStudents;
        }

        
        public string Insert_Student(int opc, P_Students student)
        {
            string answer = "";
            string sqlCommand = "";
            // Obtener la conexión a la BD
            using (MySqlConnection conn = ConnectionDB.getInstance().createConnection())
            {
                try
                {
                    string numControl = generateNumControl(student.name, student.first_lastname, student.second_lastname, student.birthdate);
                    if (opc == 1) // Insertar
                    {
                        sqlCommand = "INSERT INTO STUDENTS VALUES(" +
                            "0, @name, @lastname1, @lastname2," +
                            "@birthdate, @gender, @email, @phone, @address," +
                            "@numControl)";
                    }
                    else // Actualizar
                    {

                    }
                    // Establecer y ejectar el comando con la conexión a la BD
                    using (MySqlCommand command = new MySqlCommand(sqlCommand, conn))
                    {
                        // Parámetro con los valores de inserción
                        command.Parameters.AddWithValue("@name", student.name);
                        command.Parameters.AddWithValue("@lastname1", student.first_lastname);
                        command.Parameters.AddWithValue("@lastname2", student.second_lastname);
                        command.Parameters.AddWithValue("@birthdate", student.birthdate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@gender", student.gender);
                        command.Parameters.AddWithValue("@email", student.email_contact);
                        command.Parameters.AddWithValue("@phone", student.phone);
                        command.Parameters.AddWithValue("@address", student.address);
                        command.Parameters.AddWithValue("@numcontrol", numControl);
                        command.CommandTimeout = 60; // Establecer el tiempo de 
                        conn.Open(); // Abrir la conexión
                        answer = command.ExecuteNonQuery() >= 1 ? "OK" : "Fail";
                    }
                }
                catch (Exception ex)
                {
                    answer = ex.Message;
                }
                finally // En cualquier caso: Cerrar la conexión si está abierta
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            // Retornar la tabla
            return answer;
        }

        private string generateNumControl(string name, string lastname1, string lastname2, DateOnly birthdate)
        {
            char letterName = !string.IsNullOrEmpty(name) ? name[0] : ' ';
            char letterLastname1 = !string.IsNullOrEmpty(lastname1) ? lastname1[0] : ' ';
            char letterLastname2 = !string.IsNullOrEmpty(lastname2) ? lastname2[0] : ' ';
            string birthNumber = birthdate.ToString("ddMMyy");

            string numControl = $"{letterName}{letterLastname1}{letterLastname2}{birthNumber}";
            
            return numControl.ToUpper();
        }
    }
}
