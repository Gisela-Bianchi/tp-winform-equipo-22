using Dominio;
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
    public partial class FrmVerDetalle : Form
    {
        public FrmVerDetalle()
        {
            InitializeComponent();
        }

        private void FrmVerDetalle_Load(object sender, EventArgs e)
        {

        }
        public FrmVerDetalle(Articulo articulo)
        {
            InitializeComponent();



            textBoxCodigo.Text = articulo.Codigo;
            textBoxNombre.Text = articulo.Nombre;
            textBoxDescripcion.Text = articulo.Descripcion;





        }
    }

  
}
