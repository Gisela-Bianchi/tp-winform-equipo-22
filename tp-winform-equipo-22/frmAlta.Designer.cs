namespace tp_winform_equipo_22
{
    partial class frmAlta
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.cboIdMarca = new System.Windows.Forms.ComboBox();
            this.cboIdCategoria = new System.Windows.Forms.ComboBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(123, 93);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(123, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(95, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(183, 143);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(123, 177);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(183, 171);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(140, 316);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 43);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 43);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(400, 87);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(299, 322);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 12;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(115, 207);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(62, 16);
            this.lblIdMarca.TabIndex = 13;
            this.lblIdMarca.Text = "Id Marca:";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(94, 237);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(83, 16);
            this.lblIdCategoria.TabIndex = 14;
            this.lblIdCategoria.Text = "Id Categoria:";
            // 
            // cboIdMarca
            // 
            this.cboIdMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdMarca.FormattingEnabled = true;
            this.cboIdMarca.Location = new System.Drawing.Point(183, 199);
            this.cboIdMarca.Name = "cboIdMarca";
            this.cboIdMarca.Size = new System.Drawing.Size(121, 24);
            this.cboIdMarca.TabIndex = 15;
            // 
            // cboIdCategoria
            // 
            this.cboIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCategoria.FormattingEnabled = true;
            this.cboIdCategoria.Location = new System.Drawing.Point(183, 229);
            this.cboIdCategoria.Name = "cboIdCategoria";
            this.cboIdCategoria.Size = new System.Drawing.Size(121, 24);
            this.cboIdCategoria.TabIndex = 16;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(97, 267);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(75, 16);
            this.lblImagen.TabIndex = 17;
            this.lblImagen.Text = "Imagen Url:";
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(183, 260);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(121, 22);
            this.textBoxImagen.TabIndex = 18;
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.cboIdCategoria);
            this.Controls.Add(this.cboIdMarca);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.ComboBox cboIdMarca;
        private System.Windows.Forms.ComboBox cboIdCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox textBoxImagen;
    }
}