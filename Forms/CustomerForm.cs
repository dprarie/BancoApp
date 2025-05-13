using System;
using System.Windows.Forms;
using BancoApp.DataAccess;
using BancoApp.Models;

namespace BancoApp.Forms
{
    public partial class CustomerForm : Form
    {
        private Cliente _cliente;

        public CustomerForm(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            CargarDatosEnFormulario();
        }

        private void CargarDatosEnFormulario()
        {
            if (_cliente == null) return;

            txtFirstName.Text = _cliente.FirstName;
            txtLastName.Text = _cliente.LastName;
            txtUsername.Text = _cliente.Username;
            txtPassword.Text = _cliente.Password;
            txtCountry.Text = _cliente.Country;
            txtRegion.Text = _cliente.Region;
            txtCity.Text = _cliente.City;
            txtAddress.Text = _cliente.Address;
        }

        private void LimpiarFormulario()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCountry.Text = "";
            txtRegion.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtIdBuscar.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            _cliente = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Los campos Nombre, Usuario y Contraseña son obligatorios.");
                return;
            }

            ClienteRepository repo = new ClienteRepository();

            Cliente datosFormulario = new Cliente
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Country = txtCountry.Text,
                Region = txtRegion.Text,
                City = txtCity.Text,
                Address = txtAddress.Text
            };

            if (_cliente == null)
            {
                try
                {
                    repo.Insert(datosFormulario);
                    MessageBox.Show("Cliente insertado correctamente.");
                    _cliente = repo.Login(datosFormulario.Username, datosFormulario.Password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar cliente: " + ex.Message);
                }
            }
            else
            {
                datosFormulario.Id = _cliente.Id;

                bool ok = repo.Update(datosFormulario, _cliente.LastUpdated);
                if (ok)
                {
                    MessageBox.Show("Cambios guardados correctamente.");
                    _cliente = repo.GetById(_cliente.Id);
                }
                else
                {
                    MessageBox.Show("Este cliente ha sido modificado por otro usuario. Recárgalo antes de guardar.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                MessageBox.Show("No hay cliente cargado.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ClienteRepository repo = new ClienteRepository();
                repo.Delete(_cliente.Id);
                MessageBox.Show("Cliente eliminado.");
                LimpiarFormulario();
                _cliente = null;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdBuscar.Text.Trim(), out int id))
            {
                MessageBox.Show("Introduce un ID válido.");
                return;
            }

            ClienteRepository repo = new ClienteRepository();
            Cliente cliente = repo.GetById(id);

            if (cliente != null)
            {
                _cliente = cliente;
                CargarDatosEnFormulario();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                MessageBox.Show("Primero debes cargar o crear un cliente.");
                return;
            }

            CuentasForm cuentasForm = new CuentasForm(_cliente.Id);
            cuentasForm.ShowDialog();
        }
    }
}
