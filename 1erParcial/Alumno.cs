using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Alumno
    {
        #region Propiedades
        private string nombre { get; set; }
        private string apellido { get; set; }
        private DateTime anonacimiento { get; set; }
        private int dni { get; set; }
        private string maildecontacto { get; set; }
        private string legajo { get; set; }
        private string carrera { get; set; }
        private DateTime anoinscripcion { get; set; }
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
        public DateTime Anonacimiento
        {
            get { return this.anonacimiento; }
            set { this.anonacimiento = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Maildecontacto
        {
            get { return this.maildecontacto; }
            set { this.maildecontacto = value; }
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
        public DateTime Anoinscripcion
        {
            get { return this.anoinscripcion; }
            set { this.anoinscripcion = value; }
        }
        #endregion

        #region Constructor
        public Alumno(string nombre, string apellido, DateTime anonacimiento, int dni, string maildecontacto, string legajo, string carrera, DateTime anoinscripcion)
        {
            nombre = Nombre;
            apellido = Apellido;
            anonacimiento = Anonacimiento;
            dni = Dni;
            maildecontacto = Maildecontacto;
            legajo = Legajo;
            carrera = Carrera;
            anoinscripcion = Anoinscripcion;
        }
        #endregion
    }
}
