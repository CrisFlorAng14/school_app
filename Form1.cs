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
        // Función para cerrar la aplicación
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Llamada para establecer conexión con la BD
        MySqlConnection dbConnection = ConnectionDB.connection();
        /**
         * Función para iniciar sesión
         * Entradas: Credenciales [Usuario, Contraseña]
         * Salidas: 
         * - Acceso al dashboard
         * - Mensajes de error
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión (Si es que está cerrada)
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
                    // Consulta para verificar si el nombre de usuario y la contraseña coinciden
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
                        else // Si el usuario existe pero la contraseña es incorrecta
                        {
                            MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPass.Clear();
                        }
                    }
                }
                else // Si el usuario no existe
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Cerrar conexión (Si está abierta)
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult msgExit = MessageBox.Show("¿Estás seguro(a) de cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msgExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
