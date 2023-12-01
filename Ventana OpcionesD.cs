using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Kamil
{
    public partial class VentOpcionesD : Form
    {
        public VentOpcionesD()
        {
            InitializeComponent();
        }

        private void RegresarD_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentOpciones ventOpciones = new VentOpciones();
            ventOpciones.Show();
        }
    }
}
