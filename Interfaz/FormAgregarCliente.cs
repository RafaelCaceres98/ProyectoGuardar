using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Interfaz
{
    public partial class FormAgregarCliente : Form
    {
        Cliente cliente;
        ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);

        public FormAgregarCliente()
        {
            InitializeComponent();
        }

        public string GuardarDato() {

            cliente = new Cliente();
            cliente.Cedula = cedulaTxt.Text;
            cliente.PrimerNombre = primerNombreTxt.Text;
            cliente.SegundoNombre = segundoNombreTxt.Text;
            cliente.PrimerApellido = primerApellidoTxt.Text;
            cliente.SegundoApellido = segundoApellidoTxt.Text;
            cliente.Genero = sexoBox.SelectedItem.ToString();
            cliente.Celular = cedulaTxt.Text;
            cliente.Direccion = direccionTxt.Text;

            return clienteService.GuardarCliente(cliente);

        }

        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GuardarDato(),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
