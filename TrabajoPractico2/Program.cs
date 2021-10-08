using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrolla una clase Cafetera con atributos CapacidadMaxima(la cantidad máxima de café que puede contener la cafetera) 
            // y CantidadActual(la cantidad actual de café que hay en la cafetera para consumo). 
            // Implementa, al menos, los siguientes métodos:
            //a) Constructor predeterminado: establece la capacidad máxima en 1000 (c.c.) y la actual en cero(cafetera vacía).
            //b) LlenarCafetera() : hace que la cantidad actual sea igual a la capacidad e informa por pantalla la cantidad de café disponible para consumo.
            //c) ServirTaza(int) : simula la acción de servir una taza(100 cc), muestra por pantalla “Café servido” y la cantidad de café disponible para consumo.
            //d) VaciarCafetera() : pone la cantidad de café actual en cero e informa por pantalla “Sin café, por favor rellenar”


            //Inicializo el objeto Cafetera
            Cafetera servicio = new Cafetera();
            
            //Color de la letra en la consola
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.CursorLeft = 30;
            Console.WriteLine("BIENVENIDO AL SERVICIO DE CAFE");
            Console.CursorLeft = 30;
            Console.WriteLine("______________________________");
            Console.WriteLine("");
            servicio.LlenarCafetera();

            servicio.ServirTaza();

            servicio.VaciarCafetera();

            Console.ReadKey();
        }
    }
}