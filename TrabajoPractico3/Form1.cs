using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico3
{
    public partial class Form1 : Form
    {
        private List<Alumno> listado_de_alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //NOTA: El date time se debe ingresar como "2015, 12, 25"
            listado_de_alumnos.Add(new Alumno(txtNombre.Text, txtApellido.Text, Int32.Parse(intDni.Text),txtLegajo.Text,txtCarrera.Text, DateTime.Parse(datetimeAnodeinscripcion.Text)));
            txtNombre.Clear();
            txtApellido.Clear();
            intDni.Clear();
            txtLegajo.Clear();
            txtCarrera.Clear();
            datetimeAnodeinscripcion.Clear();
            MessageBox.Show("ALUMNO INGRESADO CORRECTAMENTE");
            lblCantidadderegistrosingresados.Text = "Numero de registros ingresados: " + (listado_de_alumnos.Count);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            intDni.Clear();
            txtLegajo.Clear();
            txtCarrera.Clear();
            datetimeAnodeinscripcion.Clear();

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadderegistrosingresados_Click(object sender, EventArgs e)
        {
            
        }
    }
}
