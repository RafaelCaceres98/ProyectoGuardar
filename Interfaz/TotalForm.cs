﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks; ce
using System.Windows.Forms;
using Entity;
using BLL;

namespace Interfaz
{
    public partial class TotalForm : Form
    {
        private CuotaService cuotaService = new CuotaService(ConfigConnection.connectionString);
        private CreditoService creditoService = new CreditoService(ConfigConnection.connectionString);
        public TotalForm()
        {
            InitializeComponent();
            TxtTotalRecaudado.Text = cuotaService.TotalRecaudado().ToString();
            TxtTotalPrestado.Text = creditoService.TotalPrestado().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void TotalForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtTotalRecaudado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
