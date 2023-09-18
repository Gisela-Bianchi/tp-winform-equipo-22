namespace tp_winform_equipo_22
{
    partial class FrmVerDetalle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labeldescripcion = new System.Windows.Forms.Label();
            this.labelidCategoria = new System.Windows.Forms.Label();
            this.labelidMarca = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxidCategoria = new System.Windows.Forms.TextBox();
            this.textBoxidMarca = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 307);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(440, 107);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(440, 157);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(59, 16);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "CODIGO";
            // 
            // labeldescripcion
            // 
            this.labeldescripcion.AutoSize = true;
            this.labeldescripcion.Location = new System.Drawing.Point(422, 201);
            this.labeldescripcion.Name = "labeldescripcion";
            this.labeldescripcion.Size = new System.Drawing.Size(98, 16);
            this.labeldescripcion.TabIndex = 3;
            this.labeldescripcion.Text = "DESCRIPCION";
            // 
            // labelidCategoria
            // 
            this.labelidCategoria.AutoSize = true;
            this.labelidCategoria.Location = new System.Drawing.Point(422, 246);
            this.labelidCategoria.Name = "labelidCategoria";
            this.labelidCategoria.Size = new System.Drawing.Size(101, 16);
            this.labelidCategoria.TabIndex = 4;
            this.labelidCategoria.Text = "ID CATEGORIA";
            // 
            // labelidMarca
            // 
            this.labelidMarca.AutoSize = true;
            this.labelidMarca.Location = new System.Drawing.Point(440, 293);
            this.labelidMarca.Name = "labelidMarca";
            this.labelidMarca.Size = new System.Drawing.Size(71, 16);
            this.labelidMarca.TabIndex = 5;
            this.labelidMarca.Text = "ID MARCA";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(540, 104);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(540, 151);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigo.TabIndex = 7;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(540, 195);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescripcion.TabIndex = 8;
            // 
            // textBoxidCategoria
            // 
            this.textBoxidCategoria.Location = new System.Drawing.Point(540, 240);
            this.textBoxidCategoria.Name = "textBoxidCategoria";
            this.textBoxidCategoria.Size = new System.Drawing.Size(100, 22);
            this.textBoxidCategoria.TabIndex = 9;
            // 
            // textBoxidMarca
            // 
            this.textBoxidMarca.Location = new System.Drawing.Point(540, 287);
            this.textBoxidMarca.Name = "textBoxidMarca";
            this.textBoxidMarca.Size = new System.Drawing.Size(100, 22);
            this.textBoxidMarca.TabIndex = 10;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(440, 332);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(57, 16);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "PRECIO";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(540, 329);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecio.TabIndex = 12;
            // 
            // FrmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxidMarca);
            this.Controls.Add(this.textBoxidCategoria);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelidMarca);
            this.Controls.Add(this.labelidCategoria);
            this.Controls.Add(this.labeldescripcion);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVerDetalle";
            this.Text = "FrmVerDetalle";
            this.Load += new System.EventHandler(this.FrmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labeldescripcion;
        private System.Windows.Forms.Label labelidCategoria;
        private System.Windows.Forms.Label labelidMarca;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxidCategoria;
        private System.Windows.Forms.TextBox textBoxidMarca;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}