namespace BancoApp.Forms
{
    partial class CuentasForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Panel headerPanel, contentPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel toolbarPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            // Inicialización de componentes
            this.headerPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();

            // Panel de encabezado con título
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 60;
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Cuentas del Cliente";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.headerPanel.Controls.Add(this.lblTitle);

            // Panel de contenido
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);

            // Panel de herramientas para botones
            this.toolbarPanel.BackColor = System.Drawing.Color.White;
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.Height = 60;
            this.toolbarPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);



            // Configuración del DataGridView
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            this.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Estilo de las celdas de encabezado
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.ColumnHeadersHeight = 40;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCuentas.EnableHeadersVisualStyles = false;

            // Estilo de las celdas normales
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentas.DefaultCellStyle = dataGridViewCellStyle2;

            // Estilo de las celdas seleccionadas
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCuentas.RowsDefaultCellStyle = dataGridViewCellStyle3;

            // Más configuraciones del DataGridView
            this.dgvCuentas.MultiSelect = false;
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersVisible = false;
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.RowTemplate.Height = 35;
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.ShowEditingIcon = false;
            this.dgvCuentas.Size = new System.Drawing.Size(800, 450);
            this.dgvCuentas.TabIndex = 0;

            // Diseño final del formulario
            this.contentPanel.Controls.Add(this.dgvCuentas);
            this.contentPanel.Controls.Add(this.toolbarPanel);

            // Formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CuentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BancoApp - Cuentas";
            this.Load += new System.EventHandler(this.CuentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}