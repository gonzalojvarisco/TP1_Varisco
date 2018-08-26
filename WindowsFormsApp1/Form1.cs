using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventana : Form
    {
        public ventana()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana2 nuevaVentana = new ventana2();

            nuevaVentana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            this.Hide();
            formListaObjetos nvaVentana = new formListaObjetos();
            nvaVentana.Show();
        }
    }
}
