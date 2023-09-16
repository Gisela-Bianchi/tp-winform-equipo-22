using Dominio;
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

namespace tp_winform_equipo_22
{
    public partial class Busqueda_por_criterios : Form
    {
        public Busqueda_por_criterios()
        {
            InitializeComponent();
        }

        private void txbNombreArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txbNombreArticulo.Text == "")
            {
                return;
            }
            ArticuloNegocio negocio = new ArticuloNegocio();

            List<Articulo> ListaArticulo = negocio.listarUnico(txbNombreArticulo.Text);
            dgvArticuloUnico.DataSource = ListaArticulo;
            



        }

        private void Busqueda_por_criterios_Load(object sender, EventArgs e)
        {

        }
    }
}
