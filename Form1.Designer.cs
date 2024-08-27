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
            imgLogo = new PictureBox();
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
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.BackColor = Color.White;
            pnlHead.Controls.Add(imgLogo);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(541, 91);
            pnlHead.TabIndex = 1;
            // 
            // imgLogo
            // 
            imgLogo.Anchor = AnchorStyles.None;
            imgLogo.BackColor = Color.Transparent;
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(222, 0);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(100, 91);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
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
            pnlBody.Location = new Point(0, 91);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(541, 365);
            pnlBody.TabIndex = 2;
            // 
            // iconButton1
            // 
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
            iconButton1.Location = new Point(454, 322);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(65, 31);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Salir";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 27);
            label1.Name = "label1";
            label1.Size = new Size(153, 26);
            label1.TabIndex = 5;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Franklin Gothic Book", 11.25F);
            txtPass.Location = new Point(131, 158);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(331, 38);
            txtPass.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Franklin Gothic Book", 11.25F);
            txtUser.Location = new Point(131, 98);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(331, 38);
            txtUser.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(4, 58, 96);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(190, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 49);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // iconPictureBox1
            // 
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
            ClientSize = new Size(541, 456);
            Controls.Add(pnlBody);
            Controls.Add(pnlHead);
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHead;
        private PictureBox imgLogo;
        private Panel pnlBody;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private Button btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
