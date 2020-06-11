namespace Interfaz
{
    partial class FormGestionPagos
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
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgClientes
            // 
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Location = new System.Drawing.Point(83, 69);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(680, 361);
            this.DtgClientes.TabIndex = 0;
            this.DtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula:";
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Location = new System.Drawing.Point(301, 32);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(140, 20);
            this.cedulaTxt.TabIndex = 2;
            this.cedulaTxt.TextChanged += new System.EventHandler(this.cedulaTxt_TextChanged);
            // 
            // buscarBtn
            // 
            this.buscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarBtn.Location = new System.Drawing.Point(468, 28);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(78, 30);
            this.buscarBtn.TabIndex = 3;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // FormGestionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.cedulaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionPagos";
            this.Text = "ForGestionPagos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.Button buscarBtn;
    }
}