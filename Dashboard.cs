using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace SchoolApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Acción para el botón Home, si corresponde.
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            openStudentForm(new FrmStudents());
        }

        private void openStudentForm(Form studentForm)
        {
            // Verifica si hay controles en pnlContainer y los elimina si es necesario
            if (this.pnlContainer.Controls.Count > 0)
            {
                this.pnlContainer.Controls.RemoveAt(0);
            }

            // Configura el formulario para que se ajuste al tamaño del panel
            studentForm.TopLevel = false; // Cambiar a false para que no sea de nivel superior
            studentForm.Dock = DockStyle.Fill;  // Esto asegura que el formulario llene el panel
            studentForm.AutoScroll = true; // Habilita el scroll si es necesario

            // Agrega y muestra el formulario en el contenedor
            this.pnlContainer.Controls.Add(studentForm);
            this.pnlContainer.Tag = studentForm;
            studentForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult msgLogout = MessageBox.Show("¿Estás seguro(a) de cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgLogout == DialogResult.Yes)
            {
                Form1 frmLogin = new Form1();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
