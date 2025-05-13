using System;
using System.Windows.Forms;
using BancoApp.DataAccess;
using BancoApp.Models;

namespace BancoApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, introduce usuario y contraseña.");
                return;
            }

            ClienteRepository repo = new ClienteRepository();
            Cliente cliente = repo.Login(username, password);

            if (cliente != null)
            {
                this.Hide();
                CustomerForm mainForm = new CustomerForm(cliente);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void layoutLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
