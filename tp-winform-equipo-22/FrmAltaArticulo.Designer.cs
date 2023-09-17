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
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.cboIdMarca = new System.Windows.Forms.ComboBox();
            this.cboIdCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(116, 43);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(51, 16);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(111, 92);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(92, 140);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(177, 140);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(121, 22);
            this.textDescripcion.TabIndex = 2;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(177, 92);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(121, 22);
            this.textNombre.TabIndex = 1;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(177, 43);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(121, 22);
            this.textCodigo.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(63, 352);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(92, 39);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(201, 352);
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
            this.labelPrecio.Location = new System.Drawing.Point(112, 185);
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
            this.textPrecio.Size = new System.Drawing.Size(121, 22);
            this.textPrecio.TabIndex = 3;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(92, 294);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(72, 16);
            this.labelImagen.TabIndex = 14;
            this.labelImagen.Text = "Url Imagen";
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(177, 294);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(121, 22);
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
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(112, 219);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(59, 16);
            this.lblIdMarca.TabIndex = 17;
            this.lblIdMarca.Text = "Id Marca";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(87, 256);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(80, 16);
            this.lblIdCategoria.TabIndex = 18;
            this.lblIdCategoria.Text = "Id Categoria";
            // 
            // cboIdMarca
            // 
            this.cboIdMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdMarca.FormattingEnabled = true;
            this.cboIdMarca.Location = new System.Drawing.Point(177, 219);
            this.cboIdMarca.Name = "cboIdMarca";
            this.cboIdMarca.Size = new System.Drawing.Size(121, 24);
            this.cboIdMarca.TabIndex = 19;
            // 
            // cboIdCategoria
            // 
            this.cboIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCategoria.FormattingEnabled = true;
            this.cboIdCategoria.Location = new System.Drawing.Point(177, 256);
            this.cboIdCategoria.Name = "cboIdCategoria";
            this.cboIdCategoria.Size = new System.Drawing.Size(121, 24);
            this.cboIdCategoria.TabIndex = 20;
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(697, 505);
            this.Controls.Add(this.cboIdCategoria);
            this.Controls.Add(this.cboIdMarca);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.lblIdMarca);
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
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.ComboBox cboIdMarca;
        private System.Windows.Forms.ComboBox cboIdCategoria;
    }
}