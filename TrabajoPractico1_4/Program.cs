using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el algoritmo que nos permita introducir 10 números por teclado y nos informe,
            //por cada uno, si es par o impar.  Como información adicional, nos debe indicar el
            //total de números pares y el total de números impares.

            //Solicito el ingreso de 10 numeros
            Console.WriteLine("ingrese 10 numeros:");
            // Defino 4 variables de tipo numerico entero.
            int a, b, c, i;
            //Asigno valores a dos de ellas, que usare como acumuladores
            b = 0;
            c = 0;
            //Calculo por cada numero ingresado si la division tiene resto
            for (i = 1; i <= 10; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0)
                {
                    b = b + 1;

                    Console.WriteLine(a + " es par");

                }
                if (a % 2 != 0)
                {
                    c = c + 1;
                    Console.WriteLine(a + " es impar");
                }

            }
            //Muestro en pantalla la cantidad de numeros pares e impares acumulados en los contadores
            //b y c
            Console.WriteLine("La cantidad de numeros pares es de: " + b);
            Console.WriteLine("La cantidad de numeros impares es de: " + c);

            Console.ReadKey();
        }
    }
}
