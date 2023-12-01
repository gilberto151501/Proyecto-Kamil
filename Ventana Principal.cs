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
    public partial class VentOpciones : Form
    {
        public VentOpciones()
        {
            InitializeComponent();
        }

        private void OpC_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentOpcionesC ventOpcionesC = new VentOpcionesC();
            ventOpcionesC.Show();
        }

        private void OpE_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentOpcionesE ventOpcionesE = new VentOpcionesE();
            ventOpcionesE.Show();   
        }

        private void OpD_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentOpcionesD ventOpcionesD = new VentOpcionesD();  
            ventOpcionesD.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
