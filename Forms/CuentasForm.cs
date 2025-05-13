using System;
using System.Data;
using System.Windows.Forms;
using BancoApp.DataAccess;

namespace BancoApp.Forms
{
    public partial class CuentasForm : Form
    {
        private int _clienteId;

        public CuentasForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
        }

        private void CuentasForm_Load(object sender, EventArgs e)
        {
            CuentaRepository repo = new CuentaRepository();
            DataTable cuentas = repo.GetCuentasInfoByClienteId(_clienteId);
            dgvCuentas.DataSource = cuentas;
        }
    }
}
