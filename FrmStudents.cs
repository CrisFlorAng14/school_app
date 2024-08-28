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
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

        }
        private void Row_Format()
        {
            tblStudents.Columns[0].Width = 25;
        }
        private void List_Students(string sText)
        {
            D_Students students = new D_Students();
            tblStudents.DataSource = students.List_Students(sText);
            this.Row_Format();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            this.List_Students("%");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.List_Students(txtSearch.Text);
        }
    }


}
