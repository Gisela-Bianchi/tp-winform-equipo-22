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
            ArticuloNegocio negocio = new ArticuloNegocio();
            //dgvArticulos.DataSource = negocio.listar();
            ListaArticulo = negocio.listar();
            dgvArticulos.DataSource = ListaArticulo;


        }
    }
}
