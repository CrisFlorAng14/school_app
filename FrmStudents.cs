using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class FrmStudents : Form
    {
        /**
         * ------ ###### MENSAJES DE ALERTA ######### --------
         */
        private static class Messages
        {
            public const string RequiredFields = "Los campos Nombre, Apellido, Nacimiento, Email y Teléfono son obligatorios.";
            public const string SuccessfulRegistration = "Alumno registrado correctamente";
            public const string RegistrationError = "Error de registro";
            public const string UpdateSuccess = "Alumno actualizado correctamente";
            public const string RowSelectionWarning = "Por favor, seleccione una fila antes de actualizar.";
            public const string SuccessfulDelete = "Registro eliminado correctamente";
            public const string DeleteError = "Error al eliminar el registro";
        }
        /**
         * ------ ###### AL CARGAR COMPONENTES ######### --------
         */
        public FrmStudents()
        {
            InitializeComponent();
        }
        // Función para listar registros al cargar el formulario
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            // Se envía % para mostrar todos los registros
            ListStudents("%");
        }
        /**
         * ------ ###### FUNCIONES CLICK ######### --------
         */
        // Función para agregar al estudiante
        private void btnAddStudent_Click(object sender, EventArgs e)
        {            
            // Se valida si los campos no son correctos -> se termina el proceso
            if (!ValidateRequiredFields()) 
                return;
            // Se crea el estudiante
            var student = CreateStudentFromInput();
            var result = new D_Students().Insert_Student(1, student);
            // Se manda el mensaje de alerta
            HandleDatabaseResponse(result, Messages.SuccessfulRegistration);
        }
        // Función para guardar cambios de modificación del estudiante
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Se valida si los campos no son correctos -> se termina el proceso
            if (!ValidateRequiredFields()) return;
            // Se actualiza el estudiante
            var student = CreateStudentFromInput();
            var result = new D_Students().Insert_Student(2, student);
            // Se manda el mensaje de alerta
            HandleDatabaseResponse(result, Messages.UpdateSuccess);
        }
        // Función para buscar
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Se filtran registros segun el valor de búsqueda (txtSearch)
            ListStudents(txtSearch.Text);
        }
        // Función para activar controles de modificación
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Si en la tabla se selecciona al menos 1 fila
            if (tblStudents.SelectedRows.Count > 0)
            {
                // Se obtiene los datos de la filta
                var selectedRow = tblStudents.SelectedRows[0];
                // Muestra los datos de la fila en los campos y activa/desactiva controles
                ShowData(selectedRow);
                ToggleActionButtons(true);
                ToggleCRUDButtons(false);
            }
            else // Mensaje de alerta para seleccionar al menos 1 fila
            {
                MessageBox.Show(Messages.RowSelectionWarning, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Función para cancelar controles de modificación
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs(); // Se limpian los campos de entrada
            ToggleActionButtons(false); // Se desactivan los botones de modificación
            ToggleCRUDButtons(true); // Se activan los botones de CRUD
        }
        // Función para eliminar registro de estudiante
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Si en la tabla se selecciona al menos 1 fila
            if (tblStudents.SelectedRows.Count > 0)
            {
                // Se muestra el mensaje de confirmación de eliminación
                var result = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Aviso de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                // Si se confirma
                if (result == DialogResult.Yes)
                {
                    // Obtiene el ID del registro del estudiante
                    var studentId = tblStudents.SelectedRows[0].Cells[0].Value.ToString();
                    // Se elimina el registro
                    var response = new D_Students().deleteStudent(studentId);
                    // Se muestra el mensaje
                    HandleDatabaseResponse(response, Messages.SuccessfulDelete);
                }
            }
            else // De lo contrario, muestra el mensaje de alerta
            {
                MessageBox.Show(Messages.RowSelectionWarning, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * ------ ###### FUNCIONES PERSONALIZADAS ######### --------
         */
        /**
         * Función para listar registros en el DataGrid
         * Entrada: Valor de búsqueda
         * Salida: Registros filtrados
         */
        private void ListStudents(string filter)
        {
            // Muestra los registros según el filtro
            tblStudents.DataSource = new D_Students().List_Students(filter);
            FormatRow();
        }
        /**
         * Función para mostrar controles de modificación
         * Entrada: Valor booleano
         * Salida: Mostrar/Ocultar botones
         */
        private void ToggleActionButtons(bool status)
        {
            btnSave.Visible = status;
            btnCancel.Visible = status;
        }
        /**
         * Función para formato de columnas en el DataGrid
         */
        private void FormatRow()
        {
            if (tblStudents.Columns.Count > 0)
            {
                tblStudents.Columns[0].Width = 25; // Ajuste para evitar errores de índice si no hay columnas
            }
        }
        /**
         * Función para limpiar los campos de entrada
         */
        private void ClearInputs()
        {
            txtName.Clear();
            txtLastname1.Clear();
            txtLastname2.Clear();
            txtBirthdate.Value = DateTime.Now; 
            txtGender.SelectedIndex = 0;
            txtEmail.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtNumber.Clear();
            txtColony.Clear();
            txtMunicipality.Clear();
            txtCP.Clear();
        }
        /**
         * Función para mostrar registros en DataGrid
         * Entrada: Fila seleccionada
         * Salida: Datos seleccionados en cada campo de entrada
         */
        private void ShowData(DataGridViewRow selectedRow)
        {
            // Validación de valores nulos y conversión de tipos
            txtName.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
            txtLastname1.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
            txtLastname2.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
            txtBirthdate.Text = selectedRow.Cells[5].Value?.ToString() ?? DateTime.Now.ToString("yyyy-MM-dd"); // Formato adecuado de fecha
            txtGender.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
            txtEmail.Text = selectedRow.Cells[7].Value?.ToString() ?? string.Empty;
            txtPhone.Text = selectedRow.Cells[8].Value?.ToString() ?? string.Empty;
            txtStreet.Text = selectedRow.Cells[9].Value?.ToString() ?? string.Empty;
            txtNumber.Text = selectedRow.Cells[10].Value?.ToString() ?? string.Empty;
            txtColony.Text = selectedRow.Cells[11].Value?.ToString() ?? string.Empty;
            txtMunicipality.Text = selectedRow.Cells[12].Value?.ToString() ?? string.Empty;
            txtCP.Text = selectedRow.Cells[13].Value?.ToString() ?? string.Empty;
        }
        /**
         * Funció para validar campos requeridos
         */
        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLastname1.Text) ||
                txtBirthdate.Value == null || 
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(Messages.RequiredFields, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        /**
         * Función para registrar estudiante desde los campos de entrada
         * Entradas: Ninguna
         * Salida: Registro nuevo
         */
        private P_Students CreateStudentFromInput()
        {
            // Control de excepciones para asegurar la conversión de tipos
            try
            {
                return new P_Students
                {
                    name = txtName.Text.Trim(),
                    first_lastname = txtLastname1.Text.Trim(),
                    second_lastname = txtLastname2.Text.Trim(),
                    birthdate = DateOnly.FromDateTime(txtBirthdate.Value), // Asegúrate de que txtBirthdate no sea null
                    gender = txtGender.Text.Trim(),
                    email_contact = txtEmail.Text.Trim(),
                    phone = txtPhone.Text.Trim(),
                    street = txtStreet.Text.Trim(),
                    number = txtNumber.Text.Trim(),
                    colony = txtColony.Text.Trim(),
                    municipality = txtMunicipality.Text.Trim(),
                    cp = txtCP.Text.Trim()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /**
         * Función para evaluar la respuesta de la BD
         * Entrada: Valor de respuesta, Mensaje de éxito
         * Salida: Mensaje de error o éxito
         */
        private void HandleDatabaseResponse(string response, string successMessage)
        {
            // Si la respuesta es "OK"
            if (response.Equals("OK"))
            {
                
                ListStudents("%"); // Se listan todos los registros
                ClearInputs(); // Se limpian los campos
                ToggleActionButtons(false); // Se ocultan los botones de modificación
                ToggleCRUDButtons(true); // Se habilitan los botones CRUD
                MessageBox.Show(successMessage, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Messages.RegistrationError, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /**
         * Función para habilitar/deshabilitar los botones del CRUD de estudiantes
         * Entrada: Dato booleano
         * Salida: Ninguna
         */
        private void ToggleCRUDButtons(bool enable)
        {
            btnAddStudent.Enabled = enable;
            btnDeleteStudent.Enabled = enable;
            btnSearch.Enabled = enable;
            txtSearch.Enabled = enable;
            tblStudents.Enabled = enable;
        }
    }
}
