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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.mrcTypesBoost = new System.Windows.Forms.GroupBox();
            this.mrcBuscador = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarTypesLista = new System.Windows.Forms.Button();
            this.btnObtenerLista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.mrcTypesBoost.SuspendLayout();
            this.mrcBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Location = new System.Drawing.Point(286, 169);
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
            this.lblPorcentaje.Location = new System.Drawing.Point(6, 121);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(106, 13);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Percentage to boost:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(6, 137);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(106, 20);
            this.txtPorcentaje.TabIndex = 2;
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.txtPorcentaje_TextChanged);
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // btnDirectorioOriginal
            // 
            this.btnDirectorioOriginal.Location = new System.Drawing.Point(286, 35);
            this.btnDirectorioOriginal.Name = "btnDirectorioOriginal";
            this.btnDirectorioOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnDirectorioOriginal.TabIndex = 3;
            this.btnDirectorioOriginal.Text = "Search";
            this.btnDirectorioOriginal.UseVisualStyleBackColor = true;
            this.btnDirectorioOriginal.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // txtDirectorioOriginal
            // 
            this.txtDirectorioOriginal.Location = new System.Drawing.Point(6, 38);
            this.txtDirectorioOriginal.Name = "txtDirectorioOriginal";
            this.txtDirectorioOriginal.Size = new System.Drawing.Size(255, 20);
            this.txtDirectorioOriginal.TabIndex = 4;
            this.txtDirectorioOriginal.TextChanged += new System.EventHandler(this.txtDirectorioOriginal_TextChanged);
            // 
            // lblDirectorioOriginal
            // 
            this.lblDirectorioOriginal.AutoSize = true;
            this.lblDirectorioOriginal.Location = new System.Drawing.Point(6, 22);
            this.lblDirectorioOriginal.Name = "lblDirectorioOriginal";
            this.lblDirectorioOriginal.Size = new System.Drawing.Size(138, 13);
            this.lblDirectorioOriginal.TabIndex = 5;
            this.lblDirectorioOriginal.Text = "Select original types.xml file:";
            // 
            // lblDirectorioModificado
            // 
            this.lblDirectorioModificado.AutoSize = true;
            this.lblDirectorioModificado.Enabled = false;
            this.lblDirectorioModificado.Location = new System.Drawing.Point(6, 71);
            this.lblDirectorioModificado.Name = "lblDirectorioModificado";
            this.lblDirectorioModificado.Size = new System.Drawing.Size(210, 13);
            this.lblDirectorioModificado.TabIndex = 8;
            this.lblDirectorioModificado.Text = "Select folder for final modified types.xml file:";
            // 
            // txtDirectorioModificado
            // 
            this.txtDirectorioModificado.Enabled = false;
            this.txtDirectorioModificado.Location = new System.Drawing.Point(6, 87);
            this.txtDirectorioModificado.Name = "txtDirectorioModificado";
            this.txtDirectorioModificado.Size = new System.Drawing.Size(255, 20);
            this.txtDirectorioModificado.TabIndex = 7;
            this.txtDirectorioModificado.TextChanged += new System.EventHandler(this.txtDirectorioModificado_TextChanged);
            // 
            // btnDirectorioModificado
            // 
            this.btnDirectorioModificado.Enabled = false;
            this.btnDirectorioModificado.Location = new System.Drawing.Point(286, 85);
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
            this.btnDescargarOriginal.Location = new System.Drawing.Point(6, 169);
            this.btnDescargarOriginal.Name = "btnDescargarOriginal";
            this.btnDescargarOriginal.Size = new System.Drawing.Size(113, 22);
            this.btnDescargarOriginal.TabIndex = 11;
            this.btnDescargarOriginal.Text = "Download Original";
            this.btnDescargarOriginal.UseVisualStyleBackColor = true;
            this.btnDescargarOriginal.Click += new System.EventHandler(this.btnDescargarOriginal_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Nominal,
            this.Min});
            this.dgvItems.Location = new System.Drawing.Point(6, 19);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.Size = new System.Drawing.Size(467, 356);
            this.dgvItems.TabIndex = 12;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 52;
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.Name = "Nominal";
            this.Nominal.ReadOnly = true;
            this.Nominal.Width = 70;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            this.Min.Width = 49;
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(398, 381);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 22);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // mrcTypesBoost
            // 
            this.mrcTypesBoost.Controls.Add(this.btnDescargarOriginal);
            this.mrcTypesBoost.Controls.Add(this.lblDirectorioModificado);
            this.mrcTypesBoost.Controls.Add(this.btnAplicar);
            this.mrcTypesBoost.Controls.Add(this.txtDirectorioModificado);
            this.mrcTypesBoost.Controls.Add(this.txtDirectorioOriginal);
            this.mrcTypesBoost.Controls.Add(this.btnDirectorioModificado);
            this.mrcTypesBoost.Controls.Add(this.lblPorcentaje);
            this.mrcTypesBoost.Controls.Add(this.lblDirectorioOriginal);
            this.mrcTypesBoost.Controls.Add(this.txtPorcentaje);
            this.mrcTypesBoost.Controls.Add(this.btnDirectorioOriginal);
            this.mrcTypesBoost.Location = new System.Drawing.Point(12, 12);
            this.mrcTypesBoost.Name = "mrcTypesBoost";
            this.mrcTypesBoost.Size = new System.Drawing.Size(367, 207);
            this.mrcTypesBoost.TabIndex = 14;
            this.mrcTypesBoost.TabStop = false;
            this.mrcTypesBoost.Text = "Loot Boost";
            // 
            // mrcBuscador
            // 
            this.mrcBuscador.Controls.Add(this.dgvItems);
            this.mrcBuscador.Controls.Add(this.btnShow);
            this.mrcBuscador.Location = new System.Drawing.Point(385, 12);
            this.mrcBuscador.Name = "mrcBuscador";
            this.mrcBuscador.Size = new System.Drawing.Size(479, 409);
            this.mrcBuscador.TabIndex = 15;
            this.mrcBuscador.TabStop = false;
            this.mrcBuscador.Text = "Items List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btnBuscarTypesLista
            // 
            this.btnBuscarTypesLista.Location = new System.Drawing.Point(298, 262);
            this.btnBuscarTypesLista.Name = "btnBuscarTypesLista";
            this.btnBuscarTypesLista.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTypesLista.TabIndex = 16;
            this.btnBuscarTypesLista.Text = "Search";
            this.btnBuscarTypesLista.UseVisualStyleBackColor = true;
            // 
            // btnObtenerLista
            // 
            this.btnObtenerLista.Enabled = false;
            this.btnObtenerLista.Location = new System.Drawing.Point(298, 310);
            this.btnObtenerLista.Name = "btnObtenerLista";
            this.btnObtenerLista.Size = new System.Drawing.Size(75, 22);
            this.btnObtenerLista.TabIndex = 12;
            this.btnObtenerLista.Text = "Print";
            this.btnObtenerLista.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObtenerLista);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscarTypesLista);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.mrcBuscador);
            this.Controls.Add(this.mrcTypesBoost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayZ Loot Boost";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.mrcTypesBoost.ResumeLayout(false);
            this.mrcTypesBoost.PerformLayout();
            this.mrcBuscador.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.GroupBox mrcTypesBoost;
        private System.Windows.Forms.GroupBox mrcBuscador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarTypesLista;
        private System.Windows.Forms.Button btnObtenerLista;
        private System.Windows.Forms.Button button1;
    }
}

