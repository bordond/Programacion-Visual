using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
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
            if (Validar())
            {
                //NOTA: El date time se debe ingresar como "2015, 12, 25"
                listado_de_alumnos.Add(new Alumno(txtNombre.Text, txtApellido.Text, DateTime.Parse(datetimeAnonacimiento.Text), Int32.Parse(intDni.Text), txtMaildecontacto.Text, txtLegajo.Text, txtCarrera.Text, DateTime.Parse(datetimeAnodeinscripcion.Text)));
                
                int n = dgvDatos.Rows.Add();
                dgvDatos.Rows[n].Cells[0].Value = txtNombre.Text;
                dgvDatos.Rows[n].Cells[1].Value = txtApellido.Text;
                dgvDatos.Rows[n].Cells[2].Value = intDni.Text;
                dgvDatos.Rows[n].Cells[3].Value = datetimeAnonacimiento.Text;
                dgvDatos.Rows[n].Cells[4].Value = txtMaildecontacto.Text;
                dgvDatos.Rows[n].Cells[5].Value = txtLegajo.Text;
                dgvDatos.Rows[n].Cells[6].Value = txtCarrera.Text;
                dgvDatos.Rows[n].Cells[7].Value = datetimeAnodeinscripcion.Text;
                //Luego de guardar el nuevo alumno y de mostrarlo en la Datagridview
                //limpiamos los campos.
                txtNombre.Clear();
                txtApellido.Clear();
                datetimeAnonacimiento.Clear();
                intDni.Clear();
                txtMaildecontacto.Clear();
                txtLegajo.Clear();
                txtCarrera.Clear();
                datetimeAnodeinscripcion.Clear();
                MessageBox.Show("ALUMNO INGRESADO CORRECTAMENTE");
                lblCantidadderegistrosingresados.Text = "Numero de registros ingresados: " + (listado_de_alumnos.Count);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los datos nuevamente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Antes de dar Guardar podemos limpiar los campos
            txtNombre.Clear();
            txtApellido.Clear();
            datetimeAnonacimiento.Clear();
            intDni.Clear();
            txtMaildecontacto.Clear();
            txtLegajo.Clear();
            txtCarrera.Clear();
            datetimeAnodeinscripcion.Clear();
        }

        private bool Validar()
        {
            bool datovalido = true;
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El campo Nombre esta vacio");
                datovalido = false;
                txtNombre.Focus();
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El campo Apellido esta vacio");
                datovalido = false;
                txtApellido.Focus();
            }
            try
            {
                //Los MessageBox comentados debajo eran para ver que calculo hacia
                //la diferencia de fechas
                int y;
                DateTime datenow = DateTime.Now;
                TimeSpan timeSpan = datenow - DateTime.Parse(datetimeAnonacimiento.Text);
                //MessageBox.Show("La diferencias de fechas da: " + timeSpan);
                int x = int.Parse(timeSpan.Days.ToString());
                //MessageBox.Show("La diferencias de fechas en string es: " + x);
                y = x;
                if (y <= 6570)//18 años x 365 dias = 6570
                {
                    MessageBox.Show("El alumno debe ser mayor de 18 años");
                    datovalido = false;
                    datetimeAnonacimiento.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El alumno debe ser mayor de 18 años");
                datovalido = false;
            }
            try
            {
                Int32.Parse(intDni.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo DNI es incorrecto o esta vacio ");
                datovalido = false;
            }
            if (txtMaildecontacto.Text.Trim() == "")
            {
                MessageBox.Show("El campo Mail de contacto esta vacio");
                datovalido = false;
                txtMaildecontacto.Focus();
            }

            if (txtLegajo.Text.Trim() == "")
            {
                MessageBox.Show("El campo Legajo esta vacio");
                datovalido = false;
                txtLegajo.Focus();
            }
            if (txtCarrera.Text.Trim() == "")
            {
                MessageBox.Show("El campo Carrera esta vacio");
                datovalido = false;
                txtCarrera.Focus();
            }
            try
            {
                //Como estamos en un metodo de validacion bool no nos deja
                //tratar DateTime, entonces lo agregue en una logica de exepcion
                if (DateTime.Parse(datetimeAnodeinscripcion.Text) == null)
                {
                    MessageBox.Show("El campo Año de Inscripcion es incorrecto o esta vacio");
                    datovalido = false;
                    datetimeAnodeinscripcion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo Año de Inscripcion es incorrecto o esta vacio");
                datovalido = false;
            }

            return datovalido;
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblCantidadderegistrosingresados_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetimeAnonacimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
