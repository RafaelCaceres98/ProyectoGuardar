using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Interfaz
{
    public partial class FrmPagar : Form
    {
        private CreditoService creditoservice = new CreditoService(ConfigConnection.connectionString);
        private CuotaService cuotaservice = new CuotaService(ConfigConnection.connectionString);
        private Cliente cliente;
        private IList<Credito> Creditos;
        public FrmPagar(Cliente Cliente)
        {
            InitializeComponent();
            cliente = Cliente;
            DtgCreditos.DataSource = null;
            DtgCreditos.DataSource = creditoservice.ConsultarCreditosCliente(cliente.Cedula);
            TxtTotalPagado.Text = cuotaservice.TotalPagado().ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

       

        private void FrmPagar_Load(object sender, EventArgs e)
        {

        }

        private void DtgCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNumero.Text = (((int)DtgCreditos.Rows[e.RowIndex].Cells[7].Value)+1).ToString();
            TxtCuota.Text = (((decimal)DtgCreditos.Rows[e.RowIndex].Cells[6].Value)).ToString();
            TxtCodigoCredito.Text = (((int)DtgCreditos.Rows[e.RowIndex].Cells[0].Value)).ToString();
        }

        private void BtnCrearCuota_Click(object sender, EventArgs e)
        {
            Creditos = creditoservice.ConsultarCreditosCliente(cliente.Cedula);
            Credito credito=new Credito();
            foreach (var item in Creditos)
            {
                if (item.NumeroCredito.Equals(int.Parse(TxtCodigoCredito.Text)))
                {
                    credito = item;
                }
            }
            Cuota cuota = new Cuota();
            cuota.NumeroCuota = int.Parse(TxtNumero.Text);
            cuota.FechaCuota = DtpFecha.Value;
            cuota.ValorCuota = decimal.Parse(TxtCuota.Text);
            cuota.AgregarCredito(credito);
            cuota.AgregarCliente(cliente);
            if (cuota.NumeroCuota > credito.NumeroCuotas)
            {
                MessageBox.Show("Usted ya ha pagado todas las cuotas.");
            }
            else
            {
                MessageBox.Show(cuotaservice.CrearCuota(cuota));
            }
            

            DtgCreditos.DataSource = null;
            DtgCreditos.DataSource = creditoservice.ConsultarCreditosCliente(cliente.Cedula);

            TxtNumero.Text = "";
            TxtCuota.Text = "";
            TxtCodigoCredito.Text = "";
            DtpFecha.Value = DateTime.Now;

        }

        private void TxtCodigoCredito_TextChanged(object sender, EventArgs e)
        {
            TxtTotalPagado.Text = cuotaservice.TotalPagadoFiltrado(TxtCodigoCredito.Text).ToString();
        }
    }
}
