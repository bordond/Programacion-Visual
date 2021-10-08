using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el algoritmo que nos permita introducir 10 números por teclado 
            //y nos informe, por cada uno, si es positivo o negativo.

            //Pido al usuario que ingrese los 10 numeros
            Console.WriteLine("Ingrese 10 numeros:");
            int[] ingresos = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ingresos[i] = int.Parse(Console.ReadLine());
            }
            //Limpio la consola
            Console.Clear();
            //verifico por cada valor del arreglo si el numero es mayor que cero, sera positivo
            //y muestro el resultado al usuario
            for (int i = 0; i < 10; i++)
            {
                if (ingresos[i] > 0)
                {
                    Console.WriteLine("El numero: " + ingresos[i] + " es positivo");
                }
            }
            //verifico por cada valor del arreglo si el numero es menor que cero, sera negativo
            //y muestro el resultado al usuario
            for (int i = 0; i < 10; i++)
            {
                if (ingresos[i] < 0)
                {
                    Console.WriteLine("El numero: " + ingresos[i] + " es negativo");
                }
            }
            Console.ReadKey();
        }
    }
}
