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
        private Articulo articulo = null;
        public frmAlta()
        {
            InitializeComponent();
        }
        public frmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            frmArticulos art = new frmArticulos();
            Marca marca = new Marca();
            Categoria categoria = new Categoria();

            try
            {   if(articulo==null)
                   articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboIdMarca.SelectedItem;
                articulo.Tipo = (Categoria)cboIdCategoria.SelectedItem;
               
             
                negocio.AgregarArticulo(articulo);
                MessageBox.Show("Agregado exitosamente");

                negocio.ModificarArticulo(articulo);
                MessageBox.Show("Modificado exitosamente");
                //art.Cargar();


                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAlta_Load(object sender, EventArgs e)
        {   
            CategoriaNegocio categoriaNegocio=new CategoriaNegocio();
            MarcaNegocio marcaNegocio=new MarcaNegocio();
            ArticuloNegocio articuloNegocio=new ArticuloNegocio();
            try
            {
                cboIdCategoria.DataSource= categoriaNegocio.listar();
                cboIdCategoria.ValueMember = "Id";
                cboIdCategoria.DisplayMember = "Descripcion";
                cboIdMarca.DataSource= marcaNegocio.listar();
                cboIdMarca.ValueMember = "Id";
                cboIdMarca.DisplayMember = "Descripcion";

                if(articulo !=null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    textBoxImagen.Text = articulo.ImagenUrl.ToString();
                    cargarImagen(articulo.ImagenUrl.ToString());
                    cboIdCategoria.SelectedValue = articulo.Tipo.Id;
                    cboIdMarca.SelectedValue = articulo.Marca.Id;



                    //cdoIdMarca.Text = articulo.Id.ToString;
                    //txtCategoria.IdCategoria.Text = articulo.Id.ToString;
                  //  txtImagenUrl.Text = articulo.ImagenUrl;



                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBoxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxImagen.Text);
        }

        private void cargarImagen(string imagen)
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
