namespace Interfaz
{
    partial class TotalForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalRecaudado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotalPrestado = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(394, 30);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(299, 3);
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
            this.button2.Location = new System.Drawing.Point(341, 3);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Recaudado:";
            // 
            // TxtTotalRecaudado
            // 
            this.TxtTotalRecaudado.Location = new System.Drawing.Point(166, 72);
            this.TxtTotalRecaudado.Name = "TxtTotalRecaudado";
            this.TxtTotalRecaudado.Size = new System.Drawing.Size(188, 20);
            this.TxtTotalRecaudado.TabIndex = 10;
            this.TxtTotalRecaudado.TextChanged += new System.EventHandler(this.TxtTotalRecaudado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Prestado";
            // 
            // TxtTotalPrestado
            // 
            this.TxtTotalPrestado.Location = new System.Drawing.Point(166, 116);
            this.TxtTotalPrestado.Name = "TxtTotalPrestado";
            this.TxtTotalPrestado.Size = new System.Drawing.Size(188, 20);
            this.TxtTotalPrestado.TabIndex = 12;
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(392, 213);
            this.Controls.Add(this.TxtTotalPrestado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotalRecaudado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalForm";
            this.Text = "TotalForm";
            this.Load += new System.EventHandler(this.TotalForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalRecaudado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotalPrestado;
    }
}