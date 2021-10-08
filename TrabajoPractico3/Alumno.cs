using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    class Alumno
    {
        //Crea una clase Alumno que modele la información que se mantiene en una
        //institución educativa.
        //Sobre cada alumno se deberá tener en cuenta las siguientes propiedades:  
        //Nombre, Apellido, DNI, Legajo, Carrera, Año de Inscripción.
        //  a)Se deberá realizar un formulario(con los controles necesarios) que permita
        // el ingreso de los datos del objeto, este se agregue a un arrary / List
        //(listado de libros). 
        //  b)Por cada alumno ingresado el sistema deberá realizar las siguientes
        //acciones: 
        // Cada control debe volver a su estado original para permitir la carga de
        //nuevos datos.
        //   Almacenar cada alumno creado en un listado de alumnos
        //   Actualizar un control Label que informe la cantidad de alumnos ingresados.
        #region Propiedades
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int dni { get; set; }
        private string legajo { get; set; }
        private string carrera { get; set; }
        private DateTime anoincripcion { get; set; }
        #endregion

        #region Metodos
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public string Carrera
        {
            get { return this.carrera; }
            set { this.carrera = value; }
        }
        public DateTime Anoincripcion
        {
            get { return this.anoincripcion; }
            set { this.anoincripcion = value; }
        }
        #endregion

        #region Constructor
        public Alumno(string nombre, string apellido, int dni, string legajo, string carrera, DateTime anoincripcion)
        {
            nombre = Nombre;
            apellido = Apellido;
            dni = Dni;
            legajo = Legajo;
            carrera = Carrera;
            anoincripcion = Anoincripcion;
        }
        #endregion
    }
}
