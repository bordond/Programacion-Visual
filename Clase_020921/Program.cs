using System;

namespace Clase_020921
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaro constante con el valor que se va a multiplicar el Array.
			const int multiplicador = 2;

			//Creo el primer Array donde van a aparecer los resultados
			int[] ArrayUno = new int[5];

			//Creo el segundo Array donde van a aparecer los resultados
			int[] ArrayDos = new int[5];

			//Cargamos el ArrayUno con los valores que ingrese el usuario
			Console.WriteLine("Ingrese 5 numeros que desea multiplicar cada uno de ellos x 2: ");

			for (int i = 0; i < ArrayUno.Length; i++)
			{
				ArrayUno[i] = int.Parse(Console.ReadLine());
				if (ArrayUno[i] > 0)
				{
					ArrayDos[i] = Calculo(ArrayUno[i],multiplicador);
				}
				else
				{
					Console.WriteLine("El valor ingresado no puede ser menor que 0 ");
					i--;
				}
			}

			Console.WriteLine("Los resultados son: ");
			MostrarArray(ArrayDos);

			Console.ReadKey();
		}
		static int Calculo(int num, int mult)
		{
			int resultado;
			resultado = num * mult;
			return resultado;
		}
		static void MostrarArray(int[] array)
		{
			foreach (int item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
