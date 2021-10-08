using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 20 números enteros positivos, indicar cuál es el mayor y en qué orden fue leído
            //(a  que elemento pertenece). Mostrar el vector completo
            //Inicializo la variable count en 0, por si trae algun otro valor
            int count = 0;
            Console.WriteLine("Ingrese 20 numeros positivos\n");
            //Seteo la cantidad de numeros a ingresar en 20
            count = 20;
            // Se instancia el array de los datos
            int[] numbers = new int[count];
            //Por cada uno de los cursores de 0 a 19 (20 en total) se ingresaran los numeros.
            Console.WriteLine("Ingrese los numeros");
            for (int temp = 0; temp < count; temp++)
            {
                numbers[temp] = int.Parse(Console.ReadLine());
            }
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("En la posicion " + i + " esta: " + numbers[i]);
            }
            //Asigno el primer valor del array de la variable numbersa la variable largest
            int largest = numbers[0];
            //Recorro todo el array de las variable numbers y realizo la comparacion sustituyendo en los casos que sea un numero mayor.
            for (int big = 1; big < numbers.Length; big++)
            {
                if (largest < numbers[big])
                {
                    largest = numbers[big];
                }
            }
            //Muestro en pantalla el resultado de la comparacion hecha por el numero mas grande (largest)
            Console.WriteLine("El numero ingresado mayor es: " + largest);
            Console.ReadKey();
        }
    }
}
