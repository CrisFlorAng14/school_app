namespace SchoolApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlHead = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            imgLogo = new PictureBox();
            panel1 = new Panel();
            pnlBody = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtPass = new TextBox();
            txtUser = new TextBox();
            btnLogin = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconUser = new FontAwesome.Sharp.IconPictureBox();
            pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panel1.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.BackColor = Color.FromArgb(4, 58, 96);
            pnlHead.Controls.Add(btnClose);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(541, 27);
            pnlHead.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(509, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 27);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // imgLogo
            // 
            imgLogo.Anchor = AnchorStyles.None;
            imgLogo.BackColor = Color.Transparent;
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(229, 0);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(100, 91);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(imgLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 91);
            panel1.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(iconButton1);
            pnlBody.Controls.Add(label1);
            pnlBody.Controls.Add(txtPass);
            pnlBody.Controls.Add(txtUser);
            pnlBody.Controls.Add(btnLogin);
            pnlBody.Controls.Add(iconPictureBox1);
            pnlBody.Controls.Add(iconUser);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 118);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(541, 338);
            pnlBody.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton1.ForeColor = Color.FromArgb(193, 33, 15);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButton1.IconColor = Color.FromArgb(193, 33, 15);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(473, 304);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(65, 31);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Salir";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Franklin Gothic Medium Cond", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 27);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 5;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Font = new Font("Franklin Gothic Book", 12F);
            txtPass.Location = new Point(131, 158);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(331, 26);
            txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Franklin Gothic Book", 12F);
            txtUser.Location = new Point(131, 98);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(331, 26);
            txtUser.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(4, 58, 96);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(191, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 49);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(4, 58, 96);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox1.IconColor = Color.FromArgb(4, 58, 96);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(65, 158);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(41, 38);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // iconUser
            // 
            iconUser.Anchor = AnchorStyles.None;
            iconUser.BackColor = Color.Transparent;
            iconUser.ForeColor = Color.FromArgb(4, 58, 96);
            iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            iconUser.IconColor = Color.FromArgb(4, 58, 96);
            iconUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconUser.IconSize = 38;
            iconUser.Location = new Point(65, 98);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(41, 38);
            iconUser.TabIndex = 0;
            iconUser.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 456);
            Controls.Add(pnlBody);
            Controls.Add(panel1);
            Controls.Add(pnlHead);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panel1.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHead;
        private PictureBox imgLogo;
        private FontAwesome.Sharp.IconButton btnClose;
        private Panel panel1;
        private Panel pnlBody;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Button btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconUser;
    }
}
