using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_160921
{
    public class Personal
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        public double _sueldo;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public Personal(int pId, string pNombre, String pApellido)
        {
            _id = pId;
            _nombre = pNombre;
            _apellido = pApellido;
            _sueldo = 0;
        }

        public Personal(int pId, string pNombre, String pApellido, double pSueldo)
        {
            _id = pId;
            _nombre = pNombre;
            _apellido = pApellido;
            _sueldo = pSueldo;
        }

        //m La palabra clave virtual se utiliza para modificar un método, propiedad, indizador o declaración de evento y permite invalidar cualquiera
        //de estos elementos en una clase derivada.
        //Para poder sobre-escribir un método (por ejemplo) en una subclase, es necesario que la clase padre tenga declarado un virtual
        public virtual void GetData()
        {
            Console.WriteLine("Full name: " + _apellido + "  " + _nombre);
            Console.WriteLine($"id: {_id}");
            if (_sueldo != 0)
            {
                Console.WriteLine($"Sueldo: {_sueldo}");
            }

        }
    }
}
