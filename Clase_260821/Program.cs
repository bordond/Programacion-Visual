using System;
// Este programa es una calculadora que suma y resta
namespace Clase_260821
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declaro las variables
			int primerdato;
			int segundodato;
			int operacion;
			int resultado;


			Console.WriteLine("Bienvenido a tu calculadora.  Elija 1 para Suma y 2 para Resta");
			operacion= int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el primer numero");
			primerdato = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese el segundo numero");
			segundodato = int.Parse(Console.ReadLine());
			
			
			if (operacion == 1)
			{
				//Operacion de suma
				resultado = primerdato + segundodato;
				Console.WriteLine($"El resultado de la suma es {resultado}.");
			}
			else if (operacion == 2)
			{
				//Operacion de resta
				resultado = primerdato - segundodato;
				Console.WriteLine($"El resultado de la resta es {resultado}");
			}
			else
			{
				Console.WriteLine("La opcion ingresada es incorrecta.");
			}
				Console.ReadKey();
		}
	}
}
