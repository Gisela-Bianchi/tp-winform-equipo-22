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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmArticulos listadoArt= new frmArticulos();
            listadoArt.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Busqueda_por_criterios Busqueda= new Busqueda_por_criterios();
            Busqueda.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }
        /*private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo modificar = new FrmAltaArticulo();
            modificar.ShowDialog();
            //cargar();
        }*/

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
