using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMatiasSP1
{
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter swLocalidad = new StreamWriter("./FormularioLocalidad.txt", true);
            swLocalidad.WriteLine(txtNombre.Text + " " + txtCiudad.Text);
            swLocalidad.Close();
            MessageBox.Show("Registrado");




            txtCiudad.Text = "";
            txtNombre.Text = "";
        }
    }
}
