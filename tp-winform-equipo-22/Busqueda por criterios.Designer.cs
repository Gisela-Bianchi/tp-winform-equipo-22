namespace tp_winform_equipo_22
{
    partial class Busqueda_por_criterios
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
            this.txbNombreArticulo = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvArticuloUnico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticuloUnico)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNombreArticulo
            // 
            this.txbNombreArticulo.Location = new System.Drawing.Point(12, 195);
            this.txbNombreArticulo.Name = "txbNombreArticulo";
            this.txbNombreArticulo.Size = new System.Drawing.Size(534, 22);
            this.txbNombreArticulo.TabIndex = 0;
            this.txbNombreArticulo.TextChanged += new System.EventHandler(this.txbNombreArticulo_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(194, 154);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(352, 26);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "ESCRIBA NOMBRE ARTICULO";
            this.lblBusqueda.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(552, 194);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvArticuloUnico
            // 
            this.dgvArticuloUnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticuloUnico.Location = new System.Drawing.Point(12, 237);
            this.dgvArticuloUnico.Name = "dgvArticuloUnico";
            this.dgvArticuloUnico.RowHeadersWidth = 51;
            this.dgvArticuloUnico.RowTemplate.Height = 24;
            this.dgvArticuloUnico.Size = new System.Drawing.Size(776, 135);
            this.dgvArticuloUnico.TabIndex = 3;
            // 
            // Busqueda_por_criterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArticuloUnico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txbNombreArticulo);
            this.Name = "Busqueda_por_criterios";
            this.Text = "Busqueda_por_criterios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticuloUnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombreArticulo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvArticuloUnico;
    }
}