namespace Interfaz
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.Contrasenalbl = new System.Windows.Forms.Label();
            this.ContrasenaTxt = new System.Windows.Forms.TextBox();
            this.EntrarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.Location = new System.Drawing.Point(73, 212);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(240, 20);
            this.UsuarioTxt.TabIndex = 1;
            // 
            // Contrasenalbl
            // 
            this.Contrasenalbl.AutoSize = true;
            this.Contrasenalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenalbl.Location = new System.Drawing.Point(143, 266);
            this.Contrasenalbl.Name = "Contrasenalbl";
            this.Contrasenalbl.Size = new System.Drawing.Size(92, 20);
            this.Contrasenalbl.TabIndex = 2;
            this.Contrasenalbl.Text = "Contraseña";
            // 
            // ContrasenaTxt
            // 
            this.ContrasenaTxt.Location = new System.Drawing.Point(74, 306);
            this.ContrasenaTxt.Name = "ContrasenaTxt";
            this.ContrasenaTxt.Size = new System.Drawing.Size(238, 20);
            this.ContrasenaTxt.TabIndex = 3;
            // 
            // EntrarBtn
            // 
            this.EntrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarBtn.Location = new System.Drawing.Point(134, 354);
            this.EntrarBtn.Name = "EntrarBtn";
            this.EntrarBtn.Size = new System.Drawing.Size(113, 25);
            this.EntrarBtn.TabIndex = 4;
            this.EntrarBtn.Text = "Entrar";
            this.EntrarBtn.UseVisualStyleBackColor = true;
            this.EntrarBtn.Click += new System.EventHandler(this.EntrarBtn_Click);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(129, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 77);
            this.label2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BtnMinimizar);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 30);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(300, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(347, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(388, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntrarBtn);
            this.Controls.Add(this.ContrasenaTxt);
            this.Controls.Add(this.Contrasenalbl);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.Label Contrasenalbl;
        private System.Windows.Forms.TextBox ContrasenaTxt;
        private System.Windows.Forms.Button EntrarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

