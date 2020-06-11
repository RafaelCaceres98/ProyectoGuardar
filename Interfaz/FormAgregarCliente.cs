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
using System.Net.Mail;

namespace Interfaz
{
    public partial class FormAgregarCliente : Form
    {
        Cliente cliente;
        Credito credito;
        ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
        CreditoService creditoservice = new CreditoService(ConfigConnection.connectionString);
        string filename;

        public FormAgregarCliente()
        {
            InitializeComponent();
            DesactivarTxt();
        }

        public string GuardarDato()
        {
            cliente = new Cliente();
            credito = new Credito();
            cliente.Cedula = cedulaTxt.Text;
            cliente.PrimerNombre = primerNombreTxt.Text;
            cliente.SegundoNombre = segundoNombreTxt.Text;
            cliente.PrimerApellido = primerApellidoTxt.Text;
            cliente.SegundoApellido = segundoApellidoTxt.Text;
            cliente.Genero = (sexoBox.Text)[0];
            cliente.Celular = cedulaTxt.Text;
            cliente.Direccion = direccionTxt.Text;
            cliente.Email = new MailAddress(txtCorreo.Text);
            credito.CuotasPagadas = 0;
            credito.NumeroCuotas = int.Parse(numeroCuotas.Value.ToString());
            credito.ValorCredito = decimal.Parse(totalTxt.Text);
            credito.AgregarCliente(cliente);
            credito.CalcularCredito();
            credito.FechaInicial = DtpFechaInicial.Value;
            credito.FechaFinal = DtpFechaFinal.Value;
            GuardarPDF(cliente);
            return clienteService.GuardarCliente(cliente, credito, filename);
        }

        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DesactivarTxt()
        {
            primerNombreTxt.Enabled = false;
            segundoNombreTxt.Enabled = false;
            primerApellidoTxt.Enabled = false;
            segundoApellidoTxt.Enabled = false;
            txtCorreo.Enabled = false;
            sexoBox.Enabled = false;
            celularTxt.Enabled = false;
            direccionTxt.Enabled = false;

        }

        private void ActivarTxt()
        {
            primerNombreTxt.Enabled = true;
            segundoNombreTxt.Enabled = true;
            primerApellidoTxt.Enabled = true;
            segundoApellidoTxt.Enabled = true;
            txtCorreo.Enabled = true;
            sexoBox.Enabled = true;
            celularTxt.Enabled = true;
            direccionTxt.Enabled = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSolicitar_Click(object sender, EventArgs e)
        {
            Cliente cliente = BuscarCliente(cedulaTxt.Text);
            if (cliente == null)
            {
                MessageBox.Show(GuardarDato(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(GuardarDatoSinCliente(BuscarCliente(cedulaTxt.Text)), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GuardarDatoSinCliente(Cliente clientebuscado)
        {
            credito = new Credito();

            credito.CuotasPagadas = 0;
            credito.NumeroCuotas = int.Parse(numeroCuotas.Value.ToString());
            credito.ValorCredito = decimal.Parse(totalTxt.Text);
            credito.AgregarCliente(clientebuscado);
            credito.CalcularCredito();
            credito.FechaInicial = DtpFechaInicial.Value;
            credito.FechaFinal = DtpFechaFinal.Value;
            return creditoservice.GuardarCredito(credito);
        }

        private Cliente BuscarCliente(string cedula)
        {
            Cliente cliente = null;
            cliente = clienteService.BuscarCliente(cedula);
            return cliente;
        }

        private void numeroCuotas_ValueChanged(object sender, EventArgs e)
        {
            if (totalTxt.Text != "")
            {
                credito = new Credito();
                credito.CuotasPagadas = 0;
                credito.NumeroCuotas = int.Parse(numeroCuotas.Value.ToString());
                credito.ValorCredito = decimal.Parse(totalTxt.Text);
                credito.AgregarCliente(cliente);
                credito.CalcularCredito();
                totalCuotasTxt.Text = credito.ValorCuota.ToString();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (clienteService.BuscarCliente(cedulaTxt.Text) == null)
            {
                ActivarTxt();
            }
            else
            {
                Cliente cliente2;
                cliente2 = clienteService.BuscarCliente(cedulaTxt.Text);
                DesactivarTxt();
                primerNombreTxt.Text = cliente2.PrimerNombre;
                segundoNombreTxt.Text = cliente2.SegundoNombre;
                primerApellidoTxt.Text = cliente2.PrimerApellido;
                segundoApellidoTxt.Text = cliente2.SegundoApellido;
                txtCorreo.Text = cliente2.Email.ToString();
                sexoBox.Text = cliente2.Genero.ToString();
                if (cliente2.Genero == 'M')
                {
                    sexoBox.SelectedIndex = 0;
                }
                else
                {
                    sexoBox.SelectedIndex = 1;
                }
                celularTxt.Text = cliente2.Celular;
                direccionTxt.Text = cliente2.Direccion;
            }
        }

        private void GuardarPDF(Cliente cliente)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
             filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                if (filename != "")
                {
                    string mensaje = clienteService.GenerarPdf(cliente, filename);
                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se especifico una ruta ", "Generar Pdf", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
