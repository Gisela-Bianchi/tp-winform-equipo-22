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
using Negocio;


namespace tp_winform_equipo_22
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> ListaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.ImagenUrl);

        }
        /// <summary>
        /// 
        /// </summary>
        public void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvArticulos.DataSource = negocio.listar();
                ListaArticulo = negocio.listar();
                dgvArticulos.DataSource = ListaArticulo;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                BoxArticulos.Load(ListaArticulo[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarImagen(string URL)
        {
            try { BoxArticulos.Load(URL); }

            catch (Exception )
            {
                BoxArticulos.Load("https://img.freepik.com/vector-gratis/ilustracion-vectorial-diseno-grafico_24908-54512.jpg?w=2000");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           frmAlta alta= new frmAlta();
            alta.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAlta modificar = new frmAlta(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.EliminarArticulo(seleccionado.Id);
                Cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
