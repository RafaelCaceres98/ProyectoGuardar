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
    public partial class FormListaClientes : Form
    {
        private ClienteService clienteservice = new ClienteService(ConfigConnection.connectionString);
        public FormListaClientes()
        {
            InitializeComponent();
            DtgClientes.DataSource = null;
            DtgClientes.DataSource = clienteservice.ConsultarClientes();
        }

        private void cambiarEstadoBtn_Click(object sender, EventArgs e)
        {

        }

        private void DtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filtroCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtroCombo.Text.Equals("TODOS"))
            {
                DtgClientes.DataSource = null;
                DtgClientes.DataSource = clienteservice.ConsultarClientes();
            }
            if (filtroCombo.Text.Equals("MUJERES"))
            {
                DtgClientes.DataSource = null;
                DtgClientes.DataSource = clienteservice.ClientesGenero('F');
            }
            if (filtroCombo.Text.Equals("HOMBRES"))
            {
                DtgClientes.DataSource = null;
                DtgClientes.DataSource = clienteservice.ClientesGenero('M');
            }  
        }

        private void filtroLetrasTxt_TextChanged(object sender, EventArgs e)
        {
            DtgClientes.DataSource = null;
            DtgClientes.DataSource = clienteservice.ClientesFiltroCedula(filtroLetrasTxt.Text);
        }
    }
}
