using System;

namespace Clase_260821_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int valor = 0;
            int pos = 0;
            Console.WriteLine("Ese programa  usa un array de 5 posiciones,le ingresamos los datos y luego lo mostramos en pantalla");

            for (int i = 0; i < array1.Length; i++)
            {
                // lleno el vector de datos . Por favor siempre Agregar comentarios a sus codigos  
                Console.WriteLine("ingrese un numero");
                array1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < array1.Length; i++)

            {
                //recorro el vector y muestro su valor y posicion en pantalla
                valor = array1[i];
                pos = i;
                Console.WriteLine($"el numero {valor} esta en la posicion nro {pos}");



            }
            Console.ReadKey();
        }
    }
}