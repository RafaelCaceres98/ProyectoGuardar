namespace Interfaz
{
    partial class FormAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sexoBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.primerNombreTxt = new System.Windows.Forms.TextBox();
            this.segundoNombreTxt = new System.Windows.Forms.TextBox();
            this.primerApellidoTxt = new System.Windows.Forms.TextBox();
            this.segundoApellidoTxt = new System.Windows.Forms.TextBox();
            this.celularTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.totalCuotasTxt = new System.Windows.Forms.TextBox();
            this.numeroCuotas = new System.Windows.Forms.NumericUpDown();
            this.BtnSolicitar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Apellido:";
            // 
            // sexoBox
            // 
            this.sexoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoBox.FormattingEnabled = true;
            this.sexoBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.sexoBox.Location = new System.Drawing.Point(158, 212);
            this.sexoBox.Name = "sexoBox";
            this.sexoBox.Size = new System.Drawing.Size(142, 21);
            this.sexoBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total por cuotas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Número de cuotas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Préstamo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Dirección:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Celular:";
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Location = new System.Drawing.Point(157, 36);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(141, 20);
            this.cedulaTxt.TabIndex = 12;
            // 
            // primerNombreTxt
            // 
            this.primerNombreTxt.Location = new System.Drawing.Point(158, 62);
            this.primerNombreTxt.Name = "primerNombreTxt";
            this.primerNombreTxt.Size = new System.Drawing.Size(141, 20);
            this.primerNombreTxt.TabIndex = 13;
            // 
            // segundoNombreTxt
            // 
            this.segundoNombreTxt.Location = new System.Drawing.Point(158, 88);
            this.segundoNombreTxt.Name = "segundoNombreTxt";
            this.segundoNombreTxt.Size = new System.Drawing.Size(141, 20);
            this.segundoNombreTxt.TabIndex = 14;
            // 
            // primerApellidoTxt
            // 
            this.primerApellidoTxt.Location = new System.Drawing.Point(158, 120);
            this.primerApellidoTxt.Name = "primerApellidoTxt";
            this.primerApellidoTxt.Size = new System.Drawing.Size(141, 20);
            this.primerApellidoTxt.TabIndex = 15;
            // 
            // segundoApellidoTxt
            // 
            this.segundoApellidoTxt.Location = new System.Drawing.Point(157, 146);
            this.segundoApellidoTxt.Name = "segundoApellidoTxt";
            this.segundoApellidoTxt.Size = new System.Drawing.Size(141, 20);
            this.segundoApellidoTxt.TabIndex = 16;
            // 
            // celularTxt
            // 
            this.celularTxt.Location = new System.Drawing.Point(159, 250);
            this.celularTxt.Name = "celularTxt";
            this.celularTxt.Size = new System.Drawing.Size(141, 20);
            this.celularTxt.TabIndex = 17;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(157, 287);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(141, 20);
            this.direccionTxt.TabIndex = 18;
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(158, 383);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(141, 20);
            this.totalTxt.TabIndex = 19;
            // 
            // totalCuotasTxt
            // 
            this.totalCuotasTxt.Enabled = false;
            this.totalCuotasTxt.Location = new System.Drawing.Point(157, 449);
            this.totalCuotasTxt.Name = "totalCuotasTxt";
            this.totalCuotasTxt.Size = new System.Drawing.Size(141, 20);
            this.totalCuotasTxt.TabIndex = 21;
            // 
            // numeroCuotas
            // 
            this.numeroCuotas.Location = new System.Drawing.Point(158, 414);
            this.numeroCuotas.Name = "numeroCuotas";
            this.numeroCuotas.Size = new System.Drawing.Size(38, 20);
            this.numeroCuotas.TabIndex = 22;
            this.numeroCuotas.ValueChanged += new System.EventHandler(this.numeroCuotas_ValueChanged);
            // 
            // BtnSolicitar
            // 
            this.BtnSolicitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolicitar.Location = new System.Drawing.Point(371, 414);
            this.BtnSolicitar.Name = "BtnSolicitar";
            this.BtnSolicitar.Size = new System.Drawing.Size(151, 27);
            this.BtnSolicitar.TabIndex = 23;
            this.BtnSolicitar.Text = "Solicitar Préstamo";
            this.BtnSolicitar.UseVisualStyleBackColor = true;
            this.BtnSolicitar.Click += new System.EventHandler(this.BtnSolicitar_Click);
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(450, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 235);
            this.label12.TabIndex = 24;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Correo";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(157, 172);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(141, 20);
            this.txtCorreo.TabIndex = 26;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(341, 47);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(115, 29);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fecha Inicial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Fecha Final";
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Location = new System.Drawing.Point(159, 324);
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicial.TabIndex = 30;
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Location = new System.Drawing.Point(159, 355);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFinal.TabIndex = 31;
            // 
            // FormAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.DtpFechaFinal);
            this.Controls.Add(this.DtpFechaInicial);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnSolicitar);
            this.Controls.Add(this.numeroCuotas);
            this.Controls.Add(this.totalCuotasTxt);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.celularTxt);
            this.Controls.Add(this.segundoApellidoTxt);
            this.Controls.Add(this.primerApellidoTxt);
            this.Controls.Add(this.segundoNombreTxt);
            this.Controls.Add(this.primerNombreTxt);
            this.Controls.Add(this.cedulaTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sexoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarCliente";
            this.Text = "FormAgregarCliente";
            this.Load += new System.EventHandler(this.FormAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sexoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.TextBox primerNombreTxt;
        private System.Windows.Forms.TextBox segundoNombreTxt;
        private System.Windows.Forms.TextBox primerApellidoTxt;
        private System.Windows.Forms.TextBox segundoApellidoTxt;
        private System.Windows.Forms.TextBox celularTxt;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox totalCuotasTxt;
        private System.Windows.Forms.NumericUpDown numeroCuotas;
        private System.Windows.Forms.Button BtnSolicitar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DtpFechaInicial;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
    }
}