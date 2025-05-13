using System.Windows.Forms;

namespace BancoApp.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuario, lblPassword, lblTitle, lblWelcome;
        private System.Windows.Forms.TextBox txtUsername, txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogo, panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkForgotPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));

            // Inicialización de componentes
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();

            this.panelLogo.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();

            // Panel del lado izquierdo (Logo)
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Width = 300;

            // PictureBox para el logo del banco
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image"))); // Aquí se cargaría el logo
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.Location = new System.Drawing.Point((panelLogo.Width - 150) / 2, 100);
            this.pictureBoxLogo.Name = "pictureBoxLogo";

            // Título del banco en panel logo
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "BancoApp";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new System.Drawing.Point((panelLogo.Width - 160) / 2, 260);
            this.lblTitle.Size = new System.Drawing.Size(160, 45);

            // Mensaje de bienvenida
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Text = "Gestión bancaria simplificada";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Location = new System.Drawing.Point((panelLogo.Width - 200) / 2, 310);
            this.lblWelcome.Size = new System.Drawing.Size(200, 21);

            // Añadimos elementos al panel del logo
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.lblTitle);
            this.panelLogo.Controls.Add(this.lblWelcome);

            // Panel principal (formulario de login)
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(50);

            // Etiqueta de usuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(60, 140);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";

            // Campo de texto para usuario
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(60, 170);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsername.Padding = new System.Windows.Forms.Padding(8);

            // Línea decorativa debajo del campo de usuario
            Panel lineUsername = new System.Windows.Forms.Panel();
            lineUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            lineUsername.Size = new System.Drawing.Size(280, 2);
            lineUsername.Location = new System.Drawing.Point(60, 195);
            this.panelMain.Controls.Add(lineUsername);

            // Etiqueta de contraseña
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(60, 220);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña";

            // Campo de texto para contraseña
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(60, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPassword.Padding = new System.Windows.Forms.Padding(8);

            // Línea decorativa debajo del campo de contraseña
            Panel linePassword = new System.Windows.Forms.Panel();
            linePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            linePassword.Size = new System.Drawing.Size(280, 2);
            linePassword.Location = new System.Drawing.Point(60, 275);
            this.panelMain.Controls.Add(linePassword);

            // Link de olvidé contraseña
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkForgotPassword.Location = new System.Drawing.Point(210, 285);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(130, 15);
            this.linkForgotPassword.TabIndex = 5;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "¿Olvidó su contraseña?";

            // Botón de iniciar sesión
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Etiqueta de titulo en panel principal
            Label lblLoginTitle = new System.Windows.Forms.Label();
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblLoginTitle.Text = "Iniciar Sesión";
            lblLoginTitle.Location = new System.Drawing.Point(60, 60);
            this.panelMain.Controls.Add(lblLoginTitle);

            // Etiqueta de subtitulo en panel principal
            Label lblSubtitle = new System.Windows.Forms.Label();
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            lblSubtitle.Text = "Ingrese sus credenciales para acceder al sistema";
            lblSubtitle.Location = new System.Drawing.Point(60, 100);
            this.panelMain.Controls.Add(lblSubtitle);

            // Añadimos elementos al panel principal
            this.panelMain.Controls.Add(this.lblUsuario);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.linkForgotPassword);
            this.panelMain.Controls.Add(this.btnLogin);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BancoApp - Iniciar Sesión";

            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }
    }
}