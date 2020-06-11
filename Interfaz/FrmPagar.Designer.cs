namespace Interfaz
{
    partial class FrmPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DtgCreditos = new System.Windows.Forms.DataGridView();
            this.BtnCrearCuota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodigoCredito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalPagado = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.Controls.Add(this.BtnMinimizar);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 30);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinimizar.Location = new System.Drawing.Point(690, 4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(36, 23);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.Text = "Min";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(733, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(36, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DtgCreditos
            // 
            this.DtgCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCreditos.Location = new System.Drawing.Point(35, 114);
            this.DtgCreditos.Name = "DtgCreditos";
            this.DtgCreditos.Size = new System.Drawing.Size(392, 233);
            this.DtgCreditos.TabIndex = 8;
            this.DtgCreditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCreditos_CellContentClick);
            // 
            // BtnCrearCuota
            // 
            this.BtnCrearCuota.Location = new System.Drawing.Point(580, 340);
            this.BtnCrearCuota.Name = "BtnCrearCuota";
            this.BtnCrearCuota.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearCuota.TabIndex = 9;
            this.BtnCrearCuota.Text = "Crear Cuota";
            this.BtnCrearCuota.UseVisualStyleBackColor = true;
            this.BtnCrearCuota.Click += new System.EventHandler(this.BtnCrearCuota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NumeroCuota";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(570, 114);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(570, 162);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(155, 20);
            this.DtpFecha.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cuota";
            // 
            // TxtCuota
            // 
            this.TxtCuota.Enabled = false;
            this.TxtCuota.Location = new System.Drawing.Point(570, 209);
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.Size = new System.Drawing.Size(100, 20);
            this.TxtCuota.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "CodigoCredito";
            // 
            // TxtCodigoCredito
            // 
            this.TxtCodigoCredito.Enabled = false;
            this.TxtCodigoCredito.Location = new System.Drawing.Point(570, 264);
            this.TxtCodigoCredito.Name = "TxtCodigoCredito";
            this.TxtCodigoCredito.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoCredito.TabIndex = 17;
            this.TxtCodigoCredito.TextChanged += new System.EventHandler(this.TxtCodigoCredito_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Pagado";
            // 
            // TxtTotalPagado
            // 
            this.TxtTotalPagado.Enabled = false;
            this.TxtTotalPagado.Location = new System.Drawing.Point(109, 395);
            this.TxtTotalPagado.Name = "TxtTotalPagado";
            this.TxtTotalPagado.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalPagado.TabIndex = 19;
            // 
            // FrmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(778, 462);
            this.Controls.Add(this.TxtTotalPagado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodigoCredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCrearCuota);
            this.Controls.Add(this.DtgCreditos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagar";
            this.Load += new System.EventHandler(this.FrmPagar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DtgCreditos;
        private System.Windows.Forms.Button BtnCrearCuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigoCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalPagado;
    }
}