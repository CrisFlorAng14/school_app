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
        // ------ ################ INICIALIZAR COMPONENTES ############ -------
        public FrmStudents()
        {
            InitializeComponent();
        }
        // ------ ############### FUNCIONES CLICK ################### --------
        // Función Click para agregar un registro de alumno
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string answer = "";
            P_Students student = new P_Students()
            {
                name = txtName.Text.Trim(),
                first_lastname = txtLastname1.Text.Trim(),
                second_lastname = txtLastname2.Text.Trim(),
                birthdate = DateOnly.FromDateTime(txtBirthdate.Value),
                gender = txtGender.Text.Trim(),
                email_contact = txtEmail.Text.Trim(),
                phone = txtPhone.Text.Trim(),
                address = txtStreet.Text + " #" +
                          txtNumber.Text + ", col. " +
                          txtColony.Text + ", " +
                          txtMunicipality.Text + ", CP. " +
                          txtCP.Text + "."
            };
            D_Students students = new D_Students();
            answer = students.Insert_Student(1, student);
            if(answer.Equals("OK"))
            {
                this.clearInputs();
                this.List_Students("%");
                MessageBox.Show("Alumno registrado correctamente","Aviso de sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Error de registro", "Aviso de sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Función para mostrar registros al cargar el formulario
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            this.List_Students("%");
        }
        // Función para confirmar búsqueda
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.List_Students(txtSearch.Text);
        }
        
        // Función Click para activar la acción de "MODIFICAR"
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Mostrar botones de modificación
            this.ShowButtons(true);
            // Inhabilitar botones CRUD
            btnAddStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
            btnSearch.Enabled = false;

            txtSearch.Enabled = false;
            tblStudents.Enabled = false;
        }
        // Función Click para cancelar acción de "MODIFICAR"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clearInputs();
            // Ocultar botones de modificación
            this.ShowButtons(false);
            // Habilitar componentes CRUD
            btnAddStudent.Enabled = true;
            btnDeleteStudent.Enabled = true;
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
            tblStudents.Enabled = true;
        }
        // --------- ################ FUNCIONES PERSONALIZADAS ############# -----------
        /**
         * Función para listar registros de alumnos
         * Entrada: Valor de búsqueda
         * Salida: Registros de alumnos
         */
        private void List_Students(string sText)
        {
            D_Students students = new D_Students();
            tblStudents.DataSource = students.List_Students(sText);
            this.Row_Format();
        }
        /**
         * Función para mostrar botones de actualización
         * Entrada: Dato booleano (activar o desactivar)
         * Salidas: Visibilidad de botones
         */
        private void ShowButtons(bool status)
        {
            btnSave.Visible = status;
            btnCancel.Visible = status;
        }
        // Función para establecer tamaño de celdas de la tabla
        private void Row_Format()
        {
            tblStudents.Columns[0].Width = 25;
        }
        private void clearInputs()
        {
            // Limpiar TextBox
            txtName.Clear();
            txtLastname1.Clear();
            txtLastname2.Clear();
            txtBirthdate.Value = DateTime.Now;
            txtGender.SelectedIndex = 0;
            txtGender.Text = "-- Elija una opción";
            txtEmail.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtNumber.Clear();
            txtColony.Clear();
            txtMunicipality.Clear();
            txtCP.Clear();
        }
        
    }


}
