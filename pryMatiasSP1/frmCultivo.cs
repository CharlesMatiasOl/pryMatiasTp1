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
    public partial class frmCultivo : Form
    {
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre;
            int Codigo;
            //bool bandera = false;

            Nombre = txtNombreCultivo.Text;
            Codigo = Convert.ToInt32(txtCodigo.Text);


            StreamWriter swCultivo = new StreamWriter("./FormularioCultivo.txt", true);

            swCultivo.WriteLine(Nombre + " " + Codigo);
            MessageBox.Show("Registrado");
            swCultivo.Close();


            txtNombreCultivo.Text = "";
            txtCodigo.Text = "";
        }
    }
}
