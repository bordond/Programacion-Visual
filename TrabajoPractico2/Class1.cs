using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Cafetera
    {
        public int CapacidadMaxima;
        public int CantidadActual;

        public Cafetera()
        {
            CapacidadMaxima = 1000;
            CantidadActual = 0;
        }

        public void LlenarCafetera()

        {
            CantidadActual = CapacidadMaxima;
            Console.WriteLine("La cafetera esta llena, el cafe disponible es de: " + CantidadActual + " C.C");
        }


        public void ServirTaza()
        {
            if (CantidadActual != 0)
            {
                Console.WriteLine("Cafe servido");
                CantidadActual = CantidadActual - 100;
                Console.WriteLine("Queda " + CantidadActual + " cc para consumir de cafe");
            }
            else
            {
                Console.WriteLine("Ultima taza ya servida");
            }
        }

        public void VaciarCafetera()
        {
            CantidadActual = 0;
            Console.WriteLine("Sin café, por favor rellenar");
        }

    }
}