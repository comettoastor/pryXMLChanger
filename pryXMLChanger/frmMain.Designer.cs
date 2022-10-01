namespace pryXMLChanger
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.btnDirectorioOriginal = new System.Windows.Forms.Button();
            this.txtDirectorioOriginal = new System.Windows.Forms.TextBox();
            this.lblDirectorioOriginal = new System.Windows.Forms.Label();
            this.lblDirectorioModificado = new System.Windows.Forms.Label();
            this.txtDirectorioModificado = new System.Windows.Forms.TextBox();
            this.btnDirectorioModificado = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnDescargarOriginal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Location = new System.Drawing.Point(294, 201);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 22);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Apply";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Enabled = false;
            this.lblPorcentaje.Location = new System.Drawing.Point(12, 122);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(106, 13);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Percentage to boost:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(12, 138);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(106, 20);
            this.txtPorcentaje.TabIndex = 2;
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.txtPorcentaje_TextChanged);
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // btnDirectorioOriginal
            // 
            this.btnDirectorioOriginal.Location = new System.Drawing.Point(294, 37);
            this.btnDirectorioOriginal.Name = "btnDirectorioOriginal";
            this.btnDirectorioOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnDirectorioOriginal.TabIndex = 3;
            this.btnDirectorioOriginal.Text = "Search";
            this.btnDirectorioOriginal.UseVisualStyleBackColor = true;
            this.btnDirectorioOriginal.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // txtDirectorioOriginal
            // 
            this.txtDirectorioOriginal.Location = new System.Drawing.Point(12, 39);
            this.txtDirectorioOriginal.Name = "txtDirectorioOriginal";
            this.txtDirectorioOriginal.Size = new System.Drawing.Size(276, 20);
            this.txtDirectorioOriginal.TabIndex = 4;
            this.txtDirectorioOriginal.TextChanged += new System.EventHandler(this.txtDirectorioOriginal_TextChanged);
            // 
            // lblDirectorioOriginal
            // 
            this.lblDirectorioOriginal.AutoSize = true;
            this.lblDirectorioOriginal.Location = new System.Drawing.Point(12, 23);
            this.lblDirectorioOriginal.Name = "lblDirectorioOriginal";
            this.lblDirectorioOriginal.Size = new System.Drawing.Size(138, 13);
            this.lblDirectorioOriginal.TabIndex = 5;
            this.lblDirectorioOriginal.Text = "Select original types.xml file:";
            // 
            // lblDirectorioModificado
            // 
            this.lblDirectorioModificado.AutoSize = true;
            this.lblDirectorioModificado.Enabled = false;
            this.lblDirectorioModificado.Location = new System.Drawing.Point(12, 72);
            this.lblDirectorioModificado.Name = "lblDirectorioModificado";
            this.lblDirectorioModificado.Size = new System.Drawing.Size(210, 13);
            this.lblDirectorioModificado.TabIndex = 8;
            this.lblDirectorioModificado.Text = "Select folder for final modified types.xml file:";
            // 
            // txtDirectorioModificado
            // 
            this.txtDirectorioModificado.Enabled = false;
            this.txtDirectorioModificado.Location = new System.Drawing.Point(12, 88);
            this.txtDirectorioModificado.Name = "txtDirectorioModificado";
            this.txtDirectorioModificado.Size = new System.Drawing.Size(276, 20);
            this.txtDirectorioModificado.TabIndex = 7;
            this.txtDirectorioModificado.TextChanged += new System.EventHandler(this.txtDirectorioModificado_TextChanged);
            // 
            // btnDirectorioModificado
            // 
            this.btnDirectorioModificado.Enabled = false;
            this.btnDirectorioModificado.Location = new System.Drawing.Point(294, 86);
            this.btnDirectorioModificado.Name = "btnDirectorioModificado";
            this.btnDirectorioModificado.Size = new System.Drawing.Size(75, 23);
            this.btnDirectorioModificado.TabIndex = 6;
            this.btnDirectorioModificado.Text = "Search";
            this.btnDirectorioModificado.UseVisualStyleBackColor = true;
            this.btnDirectorioModificado.Click += new System.EventHandler(this.btnDirectorioModificado_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(80, 206);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 9;
            // 
            // btnDescargarOriginal
            // 
            this.btnDescargarOriginal.Location = new System.Drawing.Point(274, 9);
            this.btnDescargarOriginal.Name = "btnDescargarOriginal";
            this.btnDescargarOriginal.Size = new System.Drawing.Size(113, 22);
            this.btnDescargarOriginal.TabIndex = 11;
            this.btnDescargarOriginal.Text = "Download Original";
            this.btnDescargarOriginal.UseVisualStyleBackColor = true;
            this.btnDescargarOriginal.Click += new System.EventHandler(this.btnDescargarOriginal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 228);
            this.Controls.Add(this.btnDescargarOriginal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDirectorioModificado);
            this.Controls.Add(this.txtDirectorioModificado);
            this.Controls.Add(this.btnDirectorioModificado);
            this.Controls.Add(this.lblDirectorioOriginal);
            this.Controls.Add(this.txtDirectorioOriginal);
            this.Controls.Add(this.btnDirectorioOriginal);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.btnAplicar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayZ Loot Boost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button btnDirectorioOriginal;
        private System.Windows.Forms.TextBox txtDirectorioOriginal;
        private System.Windows.Forms.Label lblDirectorioOriginal;
        private System.Windows.Forms.Label lblDirectorioModificado;
        private System.Windows.Forms.TextBox txtDirectorioModificado;
        private System.Windows.Forms.Button btnDirectorioModificado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnDescargarOriginal;
    }
}

