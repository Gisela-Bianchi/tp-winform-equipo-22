namespace tp_winform_equipo_22
{
    partial class FrmAltaArticulo
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelidCategoria = new System.Windows.Forms.Label();
            this.labelidMarca = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.labelImagen = new System.Windows.Forms.Label();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(76, 43);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(51, 16);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(76, 95);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(70, 140);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(177, 140);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 22);
            this.textDescripcion.TabIndex = 2;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(177, 92);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 1;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(177, 43);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 22);
            this.textCodigo.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(50, 352);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(92, 39);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(180, 352);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(97, 39);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(76, 185);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 16);
            this.labelPrecio.TabIndex = 8;
            this.labelPrecio.Text = "Precio";
            // 
            // labelidCategoria
            // 
            this.labelidCategoria.AutoSize = true;
            this.labelidCategoria.Location = new System.Drawing.Point(87, 201);
            this.labelidCategoria.Name = "labelidCategoria";
            this.labelidCategoria.Size = new System.Drawing.Size(0, 16);
            this.labelidCategoria.TabIndex = 10;
            // 
            // labelidMarca
            // 
            this.labelidMarca.AutoSize = true;
            this.labelidMarca.Location = new System.Drawing.Point(88, 166);
            this.labelidMarca.Name = "labelidMarca";
            this.labelidMarca.Size = new System.Drawing.Size(0, 16);
            this.labelidMarca.TabIndex = 11;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(177, 185);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 22);
            this.textPrecio.TabIndex = 3;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(70, 247);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(72, 16);
            this.labelImagen.TabIndex = 14;
            this.labelImagen.Text = "Url Imagen";
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(177, 241);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(100, 22);
            this.textBoxImagen.TabIndex = 4;
            this.textBoxImagen.Leave += new System.EventHandler(this.textBoxImagen_Leave);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(352, 43);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(299, 322);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 16;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 505);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.labelidMarca);
            this.Controls.Add(this.labelidCategoria);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Name = "FrmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.FrmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelidCategoria;
        private System.Windows.Forms.Label labelidMarca;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
    }
}