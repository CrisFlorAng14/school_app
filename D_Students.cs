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
                    string querySelect = "SELECT students.id AS 'ID', " +
                     "num_control AS 'MATRÍCULA', " +
                     "name AS 'NOMBRE', " +
                     "first_lastname AS 'PATERNO', " +
                     "second_lastname AS 'MATERNO', " +
                     "birthdate AS 'NACIMIENTO', " +
                     "gender AS 'GÉNERO', " +
                     "email_contact AS 'EMAIL', " +
                     "phone AS 'TELÉFONO', " +
                     "street AS 'CALLE', " +
                     "number AS '#', " +
                     "colony AS 'COLONIA'," +
                     "municipality AS 'MUNICIPIO'," +
                     "cp AS 'C.P.' " +
                     "FROM STUDENTS " +
                     "INNER JOIN ADDRESSES " +
                     "ON students.id = addresses.fk_idStudent " +
                     "WHERE CONCAT(name, ' ', first_lastname, ' ', second_lastname, ' ', email_contact, ' ', phone, ' ', street, ' ', number, ' ', colony, ' ', municipality, ' ', cp) LIKE CONCAT('%', @search, '%')";

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

        /**
         * Función para insertar o actualizar estudiante
         * Entrada: Tipo de opcion, Datos de registro del estudiante
         * Salida: Respuesta de éxito o error
         */
        public string Insert_Student(int opc, P_Students student)
        {
            // Definición de cadenas para respuesta y comandos
            string answer = "";
            string sqlCommand = "";
            string sqlCommandAddress = "";
            // Establecer la conexión con MySQL
            using (MySqlConnection conn = ConnectionDB.getInstance().createConnection())
            {
                // Abrir la conexión
                conn.Open();
                // Uso de transacciones (empezar)
                MySqlTransaction transaction = conn.BeginTransaction();
                // Manejo de excepciones
                try
                {
                    // Generar número de control del estudiante
                    string numControl = generateNumControl(student.name, student.first_lastname, student.second_lastname, student.birthdate);

                    if (opc == 1) // Insertar
                    {
                        sqlCommand = "INSERT INTO STUDENTS (name, first_lastname, second_lastname, birthdate, gender, email_contact, phone, num_control) VALUES(" +
                                     "@name, @lastname1, @lastname2, @birthdate, @gender, @email, @phone, @numControl)";
                    }
                    else // Actualizar
                    {
                        sqlCommand = "UPDATE STUDENTS SET name = @name, first_lastname = @lastname1, second_lastname = @lastname2, " +
                                     "birthdate = @birthdate, gender = @gender, email_contact = @email, phone = @phone, num_control = @numControl " +
                                     "WHERE num_control = @numControl";
                    }

                    // Establecer parámetros para evitar inyecciones SQL, conexión con la BD y transacción
                    using (MySqlCommand command = new MySqlCommand(sqlCommand, conn, transaction))
                    {
                        command.Parameters.AddWithValue("@name", student.name);
                        command.Parameters.AddWithValue("@lastname1", student.first_lastname);
                        command.Parameters.AddWithValue("@lastname2", student.second_lastname);
                        command.Parameters.AddWithValue("@birthdate", student.birthdate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@gender", student.gender);
                        command.Parameters.AddWithValue("@email", student.email_contact);
                        command.Parameters.AddWithValue("@phone", student.phone);
                        command.Parameters.AddWithValue("@numControl", numControl);
                        // Tiempo de espera
                        command.CommandTimeout = 60;
                        // Ejecución de comando
                        if (command.ExecuteNonQuery() < 1)
                        {
                            throw new Exception("Error al insertar o actualizar el estudiante.");
                        }
                    }
                    // Comando para insertar dirección
                    sqlCommandAddress = "INSERT INTO ADDRESSES (street, number, colony, municipality, cp, fk_idStudent) VALUES(" +
                                        "@street, @number, @colony, @municipality, @cp, " +
                                        "(SELECT id FROM STUDENTS WHERE num_control = @numControl))";
                    // Establecer parámetros para evitar inyecciones SQL, conexión con la BD y transacción
                    using (MySqlCommand commandAddress = new MySqlCommand(sqlCommandAddress, conn, transaction))
                    {
                        commandAddress.Parameters.AddWithValue("@street", student.street);
                        commandAddress.Parameters.AddWithValue("@number", student.number);
                        commandAddress.Parameters.AddWithValue("@colony", student.colony);
                        commandAddress.Parameters.AddWithValue("@municipality", student.municipality);
                        commandAddress.Parameters.AddWithValue("@cp", student.cp);
                        commandAddress.Parameters.AddWithValue("@numControl", numControl);
                        // Tiempo de espera
                        commandAddress.CommandTimeout = 60;

                        // Ejecutación de comando de dirección
                        if (commandAddress.ExecuteNonQuery() < 1)
                        {
                            throw new Exception("Error al insertar la dirección del estudiante.");
                        }
                    }

                    // Confirmar la transacción si ambos comandos tienen éxito
                    transaction.Commit();
                    answer = "OK";
                }
                catch (Exception ex)
                {
                    // Revertir la transacción si hay un error
                    transaction.Rollback();
                    answer = "Error: " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            // Retornar la respuesta obtenida
            return answer;
        }

        /**
         * Función para eliminar un estudiante
         * Entrada: ID del estudiante
         * Salida: Respuesta de la operación
         */
        public string deleteStudent(string idStudent)
        {
            // Definición de cadenas de respuesta y comando SQL
            string answer = "";
            string sqlCommand = "";
            // Establecer conexión con la BD
            using (MySqlConnection conn = ConnectionDB.getInstance().createConnection())
            {
                // Abrir la conexión
                conn.Open();
                // Manejo de transacciones (Inicio)
                MySqlTransaction transaction = conn.BeginTransaction();
                // Manejo de excepciones
                try
                {
                    // Comando para eliminar de la BD
                    sqlCommand = "DELETE FROM STUDENTS WHERE id = @idStudent";
                    // Establecer relación entre la conexión, el comando y la transacción
                    using (MySqlCommand command = new MySqlCommand(sqlCommand, conn, transaction))
                    {
                        // Establecer parámetros para evitar inyecciones SQL
                        command.Parameters.AddWithValue ("@idStudent", idStudent);
                        // Tiempo de espera
                        command.CommandTimeout = 60;
                        // Si hay error al ejecutar
                        if (command.ExecuteNonQuery() < 1)
                        {
                            throw new Exception("Error al eliminar la dirección del estudiante.");
                        }
                    }
                    // Ejecutar la transacción al finalizar
                    transaction.Commit();
                    answer = "OK";
                }
                catch (Exception ex)
                {
                    // Cancelar la transacción
                    transaction.Rollback();
                    answer = "Error: " + ex.Message;
                }
                finally
                {
                    // Cerrar la conexión
                    conn.Close();
                }
            }
            return answer;
        }
        /**
         * Función para generar número de control
         * Entrada: Nombre, Apellidos, Fecha de nacimiento
         * Salida: Número de control
         */
        private string generateNumControl(string name, string lastname1, string lastname2, DateOnly birthdate)
        {
            // Obtener valores de acuerdo a los parámetros recibidos
            char letterName = !string.IsNullOrEmpty(name) ? name[0] : 'X';
            char letterLastname1 = !string.IsNullOrEmpty(lastname1) ? lastname1[0] : 'X';
            char letterLastname2 = !string.IsNullOrEmpty(lastname2) ? lastname2[0] : 'X';
            string birthNumber = birthdate.ToString("ddMMyy");
            // Crear número de control
            string numControl = $"{letterName}{letterLastname1}{letterLastname2}{birthNumber}";
            // Retornar número con mayúsculas
            return numControl.ToUpper();
        }
    }
}
