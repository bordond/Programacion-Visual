using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_160921
{
    public class Asistente : Personal
    {
        //Crear una clase Hija llamada Asistente, que tenga antigüedad(informado por el usuario) y horas
        //semanales(que sean informadas por el usuario) y vamos a sobrescribir el método getdata() con
        //los todos nombre, apellido, id, antigüedad y hora semanales Metodo en la clase asistente que
        //me informe el valor de la hora….
        private int _antiguedad;
        private int _horassemanales;
        private double ValorHora;
        public int Antiguedad
        {
            get { return _antiguedad; }
            set { _antiguedad = value; }
        }
        public int Horassemanales
        {
            get { return _horassemanales; }
            set { _horassemanales = value; }
        }
        public Asistente(int pId, string pNombre, string pApellido,int pantiguedad, int phorassemanales) : base(pId, pNombre, pApellido)
        {
            _antiguedad = pantiguedad;
            _horassemanales = phorassemanales;
        }

        public Asistente(int pId, string pNombre, string pApellido, double pSueldo, int pantiguedad, int phorassemanales) : base(pId, pNombre, pApellido, pSueldo)
        {
            _antiguedad = pantiguedad;
            _horassemanales = phorassemanales;
        }

        public void HoraSueldo()
        {
            if (_sueldo != 0)
            {
                ValorHora = _sueldo / Horassemanales;
                Console.WriteLine($"El valor que cobra por hora es {ValorHora}");
            }
        }
     }
}
