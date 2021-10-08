using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Dados dos vectores A y B de 30 elementos enteros, generar un vector C que contenga
                //la suma de los elementos de A y B.
                // Seteo la cantidad de numeros de cada uno de los Arreglos
                int[] ArrayA = new int[30];
                int[] ArrayB = new int[30];
                int[] ArrayR = new int[30];
                // Pido al usuario que Ingrese 30 numeros    
                Console.WriteLine("Ingrese 30 numeros que corresponden al Arreglo A: ");
                // Realizo el loop de carga de numeros de las posiciones 0 a 29 para el ArregloA
                for (int i = 0; i < ArrayA.Length; i++)
                {
                    ArrayA[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese 30 numeros que corresponden al Arreglo B: ");
                // Realizo el loop de carga de numeros de las posiciones 0 a 29 para el ArregloA
                for (int i = 0; i < ArrayB.Length; i++)
                {
                    ArrayB[i] = int.Parse(Console.ReadLine());
                }
                // Utilizando el ArregloA hago la suma de cada elemento
                for (int i = 0; i < ArrayA.Length; i++)
                    {
                    ArrayR[i] = ArrayA[i] + ArrayB[i];
                    }
                // Utilizando el ArregloR, muestro el resultado de la suma
                for (int i = 0; i < ArrayR.Length; i++)
                {
                    Console.WriteLine("La suma del Arreglo A y B es: " + ArrayR[i]);
                }
                Console.ReadKey();
            }

        }
    }
}
