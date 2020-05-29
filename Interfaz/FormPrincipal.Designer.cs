namespace Interfaz
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBtns = new System.Windows.Forms.Panel();
            this.AgregarClienteBtn = new System.Windows.Forms.Button();
            this.ListaClienteBtn = new System.Windows.Forms.Button();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.PagosBtn = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.PrincipalPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelBtns.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PanelBtns);
            this.panel1.Controls.Add(this.TotalBtn);
            this.panel1.Controls.Add(this.PagosBtn);
            this.panel1.Controls.Add(this.ClientesBtn);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 510);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 42);
            this.label1.TabIndex = 7;
            // 
            // PanelBtns
            // 
            this.PanelBtns.BackColor = System.Drawing.Color.DarkOrchid;
            this.PanelBtns.Controls.Add(this.AgregarClienteBtn);
            this.PanelBtns.Controls.Add(this.ListaClienteBtn);
            this.PanelBtns.Location = new System.Drawing.Point(8, 337);
            this.PanelBtns.Name = "PanelBtns";
            this.PanelBtns.Size = new System.Drawing.Size(123, 59);
            this.PanelBtns.TabIndex = 6;
            this.PanelBtns.Visible = false;
            // 
            // AgregarClienteBtn
            // 
            this.AgregarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarClienteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgregarClienteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarClienteBtn.Location = new System.Drawing.Point(2, 2);
            this.AgregarClienteBtn.Name = "AgregarClienteBtn";
            this.AgregarClienteBtn.Size = new System.Drawing.Size(117, 23);
            this.AgregarClienteBtn.TabIndex = 4;
            this.AgregarClienteBtn.Text = "Agregar";
            this.AgregarClienteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarClienteBtn.UseVisualStyleBackColor = true;
            this.AgregarClienteBtn.Click += new System.EventHandler(this.AgregarClienteBtn_Click);
            // 
            // ListaClienteBtn
            // 
            this.ListaClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListaClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListaClienteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListaClienteBtn.Location = new System.Drawing.Point(2, 29);
            this.ListaClienteBtn.Name = "ListaClienteBtn";
            this.ListaClienteBtn.Size = new System.Drawing.Size(117, 24);
            this.ListaClienteBtn.TabIndex = 5;
            this.ListaClienteBtn.Text = "Lista";
            this.ListaClienteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ListaClienteBtn.UseVisualStyleBackColor = true;
            this.ListaClienteBtn.Click += new System.EventHandler(this.ListaClienteBtn_Click);
            // 
            // TotalBtn
            // 
            this.TotalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TotalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalBtn.Location = new System.Drawing.Point(4, 201);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(126, 25);
            this.TotalBtn.TabIndex = 2;
            this.TotalBtn.Text = "Total";
            this.TotalBtn.UseVisualStyleBackColor = true;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // PagosBtn
            // 
            this.PagosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PagosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PagosBtn.Location = new System.Drawing.Point(3, 171);
            this.PagosBtn.Name = "PagosBtn";
            this.PagosBtn.Size = new System.Drawing.Size(127, 24);
            this.PagosBtn.TabIndex = 1;
            this.PagosBtn.Text = "Pagos";
            this.PagosBtn.UseVisualStyleBackColor = true;
            this.PagosBtn.Click += new System.EventHandler(this.PagosBtn_Click);
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientesBtn.Location = new System.Drawing.Point(2, 142);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(128, 23);
            this.ClientesBtn.TabIndex = 0;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.UseVisualStyleBackColor = true;
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            // 
            // PrincipalPanel
            // 
            this.PrincipalPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrincipalPanel.Location = new System.Drawing.Point(135, 26);
            this.PrincipalPanel.Name = "PrincipalPanel";
            this.PrincipalPanel.Size = new System.Drawing.Size(848, 510);
            this.PrincipalPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.Controls.Add(this.BtnMinimizar);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 30);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinimizar.Location = new System.Drawing.Point(889, 4);
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
            this.BtnSalir.Location = new System.Drawing.Point(936, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(36, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PrincipalPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.PanelBtns.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelBtns;
        private System.Windows.Forms.Button AgregarClienteBtn;
        private System.Windows.Forms.Button ListaClienteBtn;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Button PagosBtn;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Panel PrincipalPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnSalir;
    }
}