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

namespace Interfaz
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            if (PanelBtns.Visible)
            {
                PanelBtns.Hide();
                PagosBtn.Location = new Point(3, 169);
                TotalBtn.Location = new Point(5, 199);
            } else
            {
                PanelBtns.Location = new Point(8, 168);
                PagosBtn.Location = new Point(4, 235);
                TotalBtn.Location = new Point(3, 265);
                PanelBtns.Show();
            }
        }

        private void AgregarClienteBtn_Click(object sender, EventArgs e)
        {
            if (this.PrincipalPanel.Controls.Count > 0)
                this.PrincipalPanel.Controls.RemoveAt(0);
            FormAgregarCliente pf = new FormAgregarCliente();
            pf.TopLevel = false;
            pf.Dock = DockStyle.Fill;
            this.PrincipalPanel.Controls.Add(pf);
            this.PrincipalPanel.Tag = pf;
            pf.Show();
        }

        private void ListaClienteBtn_Click(object sender, EventArgs e)
        {
            if (this.PrincipalPanel.Controls.Count > 0)
                this.PrincipalPanel.Controls.RemoveAt(0);
            FormListaClientes pf = new FormListaClientes();
            pf.TopLevel = false;
            pf.Dock = DockStyle.Fill;
            this.PrincipalPanel.Controls.Add(pf);
            this.PrincipalPanel.Tag = pf;
            pf.Show();
        }

        private void PagosBtn_Click(object sender, EventArgs e)
        {
            if (this.PrincipalPanel.Controls.Count > 0)
                this.PrincipalPanel.Controls.RemoveAt(0);
            FormGestionPagos pf = new FormGestionPagos();
            pf.TopLevel = false;
            pf.Dock = DockStyle.Fill;
            this.PrincipalPanel.Controls.Add(pf);
            this.PrincipalPanel.Tag = pf;
            pf.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            TotalForm tf = new TotalForm();
            tf.Show();
        }
    }
}
