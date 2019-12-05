using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applista
{
    public partial class Form1 : Form
    {
        private List<clases.estudiantes > Lista = new List<clases.estudiantes >();

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLISTA_Click(object sender, EventArgs e)
        {
            clases.estudiantes estudiante = new clases.estudiantes();
            estudiante.NombreCompleto = this.txtNOMBRE.Text;
            estudiante.Genero = this.comboGENERO.Text;
            estudiante.Estadocivil = this.comboESTADOCIVIL.Text;
            estudiante.edad = this.txtEDAD.Text;

            Lista.Add(estudiante);
            //mostrar los estudiantes en la listview
            ListViewItem item = new ListViewItem(estudiante.NombreCompleto );
            listViewESTUDIANTES.Items.Add(item);
            item.SubItems.Add(estudiante.Genero);
            item.SubItems.Add(estudiante.Estadocivil);
            item.SubItems.Add(estudiante.edad);


        }
    }
}
