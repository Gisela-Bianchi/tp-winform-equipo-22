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
    }
}
