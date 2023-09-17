using Dominio;
using negocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Dominio;
//using Negocio;

namespace tp_winform_equipo_22
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio=new CategoriaNegocio();
            MarcaNegocio marcaNegocio=new MarcaNegocio();
            try
            {
                cboIdCategoria.DataSource= categoriaNegocio.listar();
                cboIdMarca.DataSource= marcaNegocio.listar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            frmArticulos art = new frmArticulos();
            Marca marca = new Marca();
            Categoria categoria = new Categoria();

            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboIdMarca.SelectedItem;
                articulo.Tipo = (Categoria)cboIdCategoria.SelectedItem;

                negocio.AgregarArticulo(articulo);
                MessageBox.Show("Agregado exitosamente");
                art.Cargar();


                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    
    }
}
