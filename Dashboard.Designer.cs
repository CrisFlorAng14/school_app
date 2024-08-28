namespace SchoolApp
{
    partial class Dashboard
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
            panel1 = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnScores = new FontAwesome.Sharp.IconButton();
            btnSubjects = new FontAwesome.Sharp.IconButton();
            btnTeachers = new FontAwesome.Sharp.IconButton();
            btnStudents = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            pnlContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 58, 96);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnScores);
            panel1.Controls.Add(btnSubjects);
            panel1.Controls.Add(btnTeachers);
            panel1.Controls.Add(btnStudents);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 479);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(4, 48, 80);
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Franklin Gothic Book", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 30;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 301);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(136, 42);
            btnExit.TabIndex = 7;
            btnExit.Text = "Salir";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnScores
            // 
            btnScores.BackColor = Color.FromArgb(4, 48, 80);
            btnScores.Dock = DockStyle.Top;
            btnScores.FlatStyle = FlatStyle.Flat;
            btnScores.Font = new Font("Franklin Gothic Book", 9F);
            btnScores.ForeColor = Color.White;
            btnScores.IconChar = FontAwesome.Sharp.IconChar.Star;
            btnScores.IconColor = Color.White;
            btnScores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScores.IconSize = 30;
            btnScores.ImageAlign = ContentAlignment.MiddleLeft;
            btnScores.Location = new Point(0, 259);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(136, 42);
            btnScores.TabIndex = 6;
            btnScores.Text = "Calificaciones";
            btnScores.TextAlign = ContentAlignment.MiddleLeft;
            btnScores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScores.UseVisualStyleBackColor = false;
            // 
            // btnSubjects
            // 
            btnSubjects.BackColor = Color.FromArgb(4, 48, 80);
            btnSubjects.Dock = DockStyle.Top;
            btnSubjects.FlatStyle = FlatStyle.Flat;
            btnSubjects.Font = new Font("Franklin Gothic Book", 9F);
            btnSubjects.ForeColor = Color.White;
            btnSubjects.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnSubjects.IconColor = Color.White;
            btnSubjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubjects.IconSize = 30;
            btnSubjects.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubjects.Location = new Point(0, 217);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(136, 42);
            btnSubjects.TabIndex = 5;
            btnSubjects.Text = "Asignaturas";
            btnSubjects.TextAlign = ContentAlignment.MiddleLeft;
            btnSubjects.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubjects.UseVisualStyleBackColor = false;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = Color.FromArgb(4, 48, 80);
            btnTeachers.Dock = DockStyle.Top;
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.Font = new Font("Franklin Gothic Book", 9F);
            btnTeachers.ForeColor = Color.White;
            btnTeachers.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            btnTeachers.IconColor = Color.White;
            btnTeachers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTeachers.IconSize = 30;
            btnTeachers.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeachers.Location = new Point(0, 175);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(136, 42);
            btnTeachers.TabIndex = 3;
            btnTeachers.Text = "Profesores";
            btnTeachers.TextAlign = ContentAlignment.MiddleLeft;
            btnTeachers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTeachers.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.FromArgb(4, 48, 80);
            btnStudents.Dock = DockStyle.Top;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Franklin Gothic Book", 9F);
            btnStudents.ForeColor = Color.White;
            btnStudents.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            btnStudents.IconColor = Color.White;
            btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudents.IconSize = 30;
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(0, 133);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(136, 42);
            btnStudents.TabIndex = 2;
            btnStudents.Text = "Alumnos";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(4, 48, 80);
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Franklin Gothic Book", 9F);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 30;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 91);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(136, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(4, 58, 96);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 91);
            panel3.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(136, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(667, 479);
            pnlContainer.TabIndex = 7;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 479);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnTeachers;
        private FontAwesome.Sharp.IconButton btnStudents;
        private FontAwesome.Sharp.IconButton btnScores;
        private FontAwesome.Sharp.IconButton btnSubjects;
        private FontAwesome.Sharp.IconButton btnExit;
        private Panel pnlContainer;
    }
}