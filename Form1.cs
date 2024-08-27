using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Llamada para establecer conexi�n con la BD
        MySqlConnection dbConnection = Connection.connection();
        /**
         * Funci�n para iniciar sesi�n
         * Entradas: Credenciales [Usuario, Contrase�a]
         * Salidas: 
         * - Acceso al dashboard
         * - Mensajes de error
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexi�n (Si es que est� cerrada)
                if (dbConnection.State == System.Data.ConnectionState.Closed)
                {
                    dbConnection.Open();
                }

                // Consulta para verificar si el usuario existe
                MySqlCommand userCheckQuery = new MySqlCommand("SELECT * FROM USERS WHERE USERNAME = @username", dbConnection);
                userCheckQuery.Parameters.AddWithValue("@username", txtUser.Text);

                bool userExists = false;

                using (MySqlDataReader userCheckReader = userCheckQuery.ExecuteReader())
                {
                    userExists = userCheckReader.HasRows;
                }
                // Si el usuario existe
                if (userExists)
                {
                    // Consulta para verificar si el nombre de usuario y la contrase�a coinciden
                    MySqlCommand loginCommand = new MySqlCommand("SELECT * FROM USERS WHERE USERNAME = @username AND PASSWORD = @password", dbConnection);
                    loginCommand.Parameters.AddWithValue("@username", txtUser.Text);
                    loginCommand.Parameters.AddWithValue("@password", txtPass.Text);

                    using (MySqlDataReader loginReader = loginCommand.ExecuteReader())
                    {
                        if (loginReader.HasRows)
                        {
                            // Si se encuentran resultados, mostrar el formulario del dashboard
                            loginReader.Read();
                            Dashboard winDashboard = new Dashboard();
                            winDashboard.Show();
                            this.Hide();
                        }
                        else // Si el usuario existe pero la contrase�a es incorrecta
                        {
                            MessageBox.Show("Contrase�a incorrecta");
                            txtPass.Clear();
                        }
                    }
                }
                else // Si el usuario no existe
                {
                    MessageBox.Show("No hay registro de usuario");
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar conexi�n (Si est� abierta)
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

    }
}
