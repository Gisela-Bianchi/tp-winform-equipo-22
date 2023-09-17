using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;
using Negocio;

namespace tp_winform_equipo_22
{
    public partial class FrmAltaArticulo : Form
    {
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            Articulo articulo = new Articulo(); 
            ArticuloNegocio negocio = new ArticuloNegocio();
            frmArticulos art = new frmArticulos();

            try
            {
                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Descripcion = textDescripcion.Text;
                articulo.Precio = decimal.Parse(textPrecio.Text);
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

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboIdCategoria.DataSource = categoriaNegocio.listar();
                cboIdMarca.DataSource = marcaNegocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxImagen.Text);
        }

        private void cargarImagen (string imagen)
        {

            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxArticulo.Load("https://instalacionesherman.com/wp-content/uploads/2018/04/Imagen_por_defecto-600x450.png");
            }
        }

    
    }
}
