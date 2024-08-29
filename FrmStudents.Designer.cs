namespace SchoolApp
{
    partial class FrmStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtLastname1 = new TextBox();
            txtLastname2 = new TextBox();
            txtEmail = new TextBox();
            txtBirthdate = new DateTimePicker();
            txtGender = new ComboBox();
            txtPhone = new TextBox();
            btnAddStudent = new FontAwesome.Sharp.IconButton();
            tblStudents = new DataGridView();
            label7 = new Label();
            txtStreet = new TextBox();
            txtNumber = new TextBox();
            txtColony = new TextBox();
            txtMunicipality = new TextBox();
            txtCP = new TextBox();
            txtSearch = new TextBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDeleteStudent = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)tblStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 13F);
            label1.Location = new Point(300, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 0;
            label1.Text = "ALUMNOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 10F);
            label2.Location = new Point(18, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 0;
            label2.Text = "Alumno*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 10F);
            label3.Location = new Point(18, 65);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 0;
            label3.Text = "Nacimiento*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 10F);
            label4.Location = new Point(459, 65);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 0;
            label4.Text = "Género";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 10F);
            label5.Location = new Point(18, 100);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 0;
            label5.Text = "Email*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 10F);
            label6.Location = new Point(370, 100);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 0;
            label6.Text = "Teléfono*";
            // 
            // txtName
            // 
            txtName.Font = new Font("Franklin Gothic Medium", 9F);
            txtName.Location = new Point(101, 35);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre(s)*";
            txtName.Size = new Size(186, 21);
            txtName.TabIndex = 1;
            // 
            // txtLastname1
            // 
            txtLastname1.Font = new Font("Franklin Gothic Medium", 9F);
            txtLastname1.Location = new Point(293, 35);
            txtLastname1.Name = "txtLastname1";
            txtLastname1.PlaceholderText = "Apellido paterno*";
            txtLastname1.Size = new Size(174, 21);
            txtLastname1.TabIndex = 2;
            // 
            // txtLastname2
            // 
            txtLastname2.Font = new Font("Franklin Gothic Medium", 9F);
            txtLastname2.Location = new Point(473, 35);
            txtLastname2.Name = "txtLastname2";
            txtLastname2.PlaceholderText = "Apellido materno";
            txtLastname2.Size = new Size(172, 21);
            txtLastname2.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Franklin Gothic Medium", 9F);
            txtEmail.Location = new Point(101, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ej. alguien@mail.com";
            txtEmail.Size = new Size(264, 21);
            txtEmail.TabIndex = 6;
            // 
            // txtBirthdate
            // 
            txtBirthdate.Font = new Font("Franklin Gothic Medium", 9F);
            txtBirthdate.Location = new Point(101, 65);
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.Size = new Size(352, 21);
            txtBirthdate.TabIndex = 4;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Franklin Gothic Medium", 9F);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "M", "F", "O" });
            txtGender.Location = new Point(510, 65);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(135, 24);
            txtGender.TabIndex = 5;
            txtGender.Text = "-- Elija una opción";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Franklin Gothic Medium", 9F);
            txtPhone.Location = new Point(441, 97);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Ej. 7771234567";
            txtPhone.Size = new Size(204, 21);
            txtPhone.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(30, 133, 13);
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatAppearance.BorderColor = Color.FromArgb(30, 133, 13);
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddStudent.IconColor = Color.White;
            btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddStudent.IconSize = 25;
            btnAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.Location = new Point(558, 203);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(87, 32);
            btnAddStudent.TabIndex = 15;
            btnAddStudent.Text = "Agregar";
            btnAddStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnAddStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // tblStudents
            // 
            tblStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblStudents.Location = new Point(18, 203);
            tblStudents.Name = "tblStudents";
            tblStudents.RowHeadersWidth = 40;
            tblStudents.Size = new Size(534, 264);
            tblStudents.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 10F);
            label7.Location = new Point(18, 129);
            label7.Name = "label7";
            label7.Size = new Size(64, 18);
            label7.TabIndex = 0;
            label7.Text = "Dirección";
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Franklin Gothic Medium", 9F);
            txtStreet.Location = new Point(101, 129);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Calle";
            txtStreet.Size = new Size(112, 21);
            txtStreet.TabIndex = 8;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Franklin Gothic Medium", 9F);
            txtNumber.Location = new Point(219, 129);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "No.";
            txtNumber.Size = new Size(40, 21);
            txtNumber.TabIndex = 9;
            // 
            // txtColony
            // 
            txtColony.Font = new Font("Franklin Gothic Medium", 9F);
            txtColony.Location = new Point(265, 129);
            txtColony.Name = "txtColony";
            txtColony.PlaceholderText = "Colonia";
            txtColony.Size = new Size(134, 21);
            txtColony.TabIndex = 10;
            // 
            // txtMunicipality
            // 
            txtMunicipality.Font = new Font("Franklin Gothic Medium", 9F);
            txtMunicipality.Location = new Point(405, 129);
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.PlaceholderText = "Municipio";
            txtMunicipality.Size = new Size(112, 21);
            txtMunicipality.TabIndex = 11;
            // 
            // txtCP
            // 
            txtCP.Font = new Font("Franklin Gothic Medium", 9F);
            txtCP.Location = new Point(523, 129);
            txtCP.Name = "txtCP";
            txtCP.PlaceholderText = "C.P.";
            txtCP.Size = new Size(122, 21);
            txtCP.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Franklin Gothic Medium", 9F);
            txtSearch.Location = new Point(18, 164);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(335, 21);
            txtSearch.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Franklin Gothic Book", 9F);
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 20;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(459, 161);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 27);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Franklin Gothic Book", 9F);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 20;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(558, 161);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 27);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(4, 58, 96);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(4, 58, 96);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnUpdate.IconColor = Color.White;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 20;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(558, 250);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 32);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Modificar";
            btnUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = Color.FromArgb(193, 33, 15);
            btnDeleteStudent.Cursor = Cursors.Hand;
            btnDeleteStudent.FlatAppearance.BorderColor = Color.FromArgb(193, 33, 15);
            btnDeleteStudent.FlatStyle = FlatStyle.Flat;
            btnDeleteStudent.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteStudent.ForeColor = Color.White;
            btnDeleteStudent.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDeleteStudent.IconColor = Color.White;
            btnDeleteStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteStudent.IconSize = 20;
            btnDeleteStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteStudent.Location = new Point(558, 299);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(87, 32);
            btnDeleteStudent.TabIndex = 17;
            btnDeleteStudent.Text = "Eliminar";
            btnDeleteStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteStudent.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.ForeColor = Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.Location = new Point(359, 158);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 33);
            btnSearch.TabIndex = 18;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 479);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(txtCP);
            Controls.Add(txtMunicipality);
            Controls.Add(txtColony);
            Controls.Add(txtNumber);
            Controls.Add(txtStreet);
            Controls.Add(label7);
            Controls.Add(tblStudents);
            Controls.Add(btnAddStudent);
            Controls.Add(txtPhone);
            Controls.Add(txtGender);
            Controls.Add(txtBirthdate);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname2);
            Controls.Add(txtLastname1);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudents";
            Text = "FrmStudent";
            Load += FrmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)tblStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLastname1;
        private TextBox txtLastname2;
        private TextBox txtEmail;
        private DateTimePicker txtBirthdate;
        private ComboBox txtGender;
        private TextBox txtPhone;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private DataGridView tblStudents;
        private Label label7;
        private TextBox txtStreet;
        private TextBox txtNumber;
        private TextBox txtColony;
        private TextBox txtMunicipality;
        private TextBox txtCP;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDeleteStudent;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}