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
        {   if (dgvArticulos.CurrentRow != null)
            {
                Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.ImagenUrl);
            }
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
                ocultarColumnas();
                BoxArticulos.Load(ListaArticulo[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro != "")
            {
               listaFiltrada = ListaArticulo.FindAll(x => x.Nombre.ToUpper().Contains (filtro.ToUpper())|| x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaArticulo;
            }



            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void buttonVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FrmVerDetalle verDetalle = new FrmVerDetalle(seleccionado);
            verDetalle.ShowDialog();
            Cargar();
        }
    }
}
