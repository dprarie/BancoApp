namespace BancoApp.Forms
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TextBox txtFirstName, txtLastName, txtUsername, txtPassword, txtCountry, txtRegion, txtCity, txtAddress, txtIdBuscar;
        private System.Windows.Forms.Button btnCargar, btnGuardar, btnEliminar, btnNuevo, btnVerCuentas;
        private System.Windows.Forms.Panel headerPanel, contentPanel, footerPanel;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));

            // Inicialización de componentes
            this.headerPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVerCuentas = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Panel de encabezado con título
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 60;
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Gestión de Clientes";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.headerPanel.Controls.Add(this.lblTitle);

            // Panel de contenido
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.AutoScroll = true;

            // Panel inferior para botones
            this.footerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Height = 70;
            this.footerPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            // Configuración del TableLayoutPanel
            this.layoutMain.BackColor = System.Drawing.Color.White;
            this.layoutMain.ColumnCount = 3;
            this.layoutMain.RowCount = 9;
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutMain.Padding = new System.Windows.Forms.Padding(20);
            this.layoutMain.AutoSize = true;
            this.layoutMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));

            // Espacio entre filas
            for (int i = 0; i < 9; i++)
            {
                this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            }

            // Estilo común para TextBoxes
            System.Windows.Forms.TextBox[] allTextBoxes = {
                txtIdBuscar, txtFirstName, txtLastName, txtUsername, txtPassword,
                txtCountry, txtRegion, txtCity, txtAddress
            };

            foreach (var textBox in allTextBoxes)
            {
                textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                textBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                textBox.Padding = new System.Windows.Forms.Padding(5);
                textBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
                textBox.Height = 30;
            }

            // Fila 0: ID Cliente + TextBox + Botón
            var lblIdCliente = new System.Windows.Forms.Label()
            {
                Text = "ID Cliente",
                Anchor = System.Windows.Forms.AnchorStyles.Left,
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular)
            };
            this.layoutMain.Controls.Add(lblIdCliente, 0, 0);

            // Estilo para el TextBox de búsqueda
            this.txtIdBuscar.Width = 180;
            this.layoutMain.Controls.Add(this.txtIdBuscar, 1, 0);

            // Estilo para el botón de búsqueda
            this.btnCargar.Text = "Buscar";
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            this.layoutMain.Controls.Add(this.btnCargar, 2, 0);

            // Filas 1-8: Datos
            string[] labels = { "Nombre", "Apellidos", "Usuario", "Contraseña", "País", "Región", "Ciudad", "Dirección" };
            System.Windows.Forms.TextBox[] textboxes = {
                txtFirstName, txtLastName, txtUsername, txtPassword,
                txtCountry, txtRegion, txtCity, txtAddress
            };

            for (int i = 0; i < labels.Length; i++)
            {
                var lbl = new System.Windows.Forms.Label()
                {
                    Text = labels[i],
                    Anchor = System.Windows.Forms.AnchorStyles.Left,
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 10F)
                };
                var tb = textboxes[i];
                tb.Width = 230;
                tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
                this.layoutMain.Controls.Add(lbl, 0, i + 1);
                this.layoutMain.Controls.Add(tb, 1, i + 1);
            }

            // Contraseña con caracteres ocultos
            this.txtPassword.UseSystemPasswordChar = true;

            // Estilo para los botones principales
            System.Windows.Forms.Button[] mainButtons = { btnGuardar, btnEliminar, btnNuevo, btnVerCuentas };
            foreach (var btn in mainButtons)
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.AutoSize = true;
                btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                btn.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5); 
                btn.FlatAppearance.BorderSize = 0;
                btn.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            }

            // Flujo de los botones de abajo
            var buttonFlow = new System.Windows.Forms.FlowLayoutPanel();
            buttonFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;

            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            btnEliminar.Text = "Eliminar";
            btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            btnNuevo.Text = "Nuevo";
            btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            btnNuevo.ForeColor = System.Drawing.Color.White;
            btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            btnVerCuentas.Text = "Ver Cuentas";
            btnVerCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            btnVerCuentas.ForeColor = System.Drawing.Color.White;
            btnVerCuentas.Click += new System.EventHandler(this.btnVerCuentas_Click);

            buttonFlow.Controls.AddRange(new System.Windows.Forms.Control[] {
                btnGuardar, btnEliminar, btnNuevo, btnVerCuentas
            });

            this.footerPanel.Controls.Add(buttonFlow);

            // Agregar los paneles principales al formulario
            this.contentPanel.Controls.Add(layoutMain);

            // Formulario
            this.BackColor = System.Drawing.Color.White;
            this.Text = "BancoApp - Gestión de Clientes";
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(contentPanel);
            this.Controls.Add(headerPanel);
            this.Controls.Add(footerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}