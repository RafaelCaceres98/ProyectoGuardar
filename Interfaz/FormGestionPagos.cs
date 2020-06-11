using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormGestionPagos : Form
    {
        ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
        public FormGestionPagos()
        {
            InitializeComponent();
            DtgClientes.DataSource = clienteService.ConsultarClientes();
        }

        private void DtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cedulaTxt_TextChanged(object sender, EventArgs e)
        {
           DtgClientes.DataSource = null;
           DtgClientes.DataSource = clienteService.ClientesFiltroCedula(cedulaTxt.Text);
        }


        public void AbrirFormPagar() 
        {
            FrmPagar frmPagar = new FrmPagar(clienteService.BuscarCliente(cedulaTxt.Text));
            frmPagar.Show();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (clienteService.BuscarCliente(cedulaTxt.Text) == null)
            {
                MessageBox.Show("No existe la cedula.");
            }
            else
            {
                AbrirFormPagar();
            }
            
        }
    }
}
