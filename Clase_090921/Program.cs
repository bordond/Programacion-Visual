using System;


namespace Clase_090921
{
    class Program
    {
        static void Main(string[] args)
        {
            Dado[] dados = new Dado[] {
                new Dado(),
                new Dado(),
                new Dado()
            };


            bool gano = false;
            while (!gano)
                gano = Jugar(dados);


        }


        static bool Jugar(Dado[] dados)
        {
            foreach (Dado dado in dados)
            {
                dado.Tirar();
                dado.MostrarValor();
            }




            bool iguales = true;


            for (int i = 1; i < dados.Length; i++)
            {
                if (dados[i].Valor != dados[0].Valor)
                {
                    iguales = false;
                    break;
                }
            }


            if (iguales)
                Console.WriteLine("Ganaste!");
            else
                Console.WriteLine("Perdiste!");


            return iguales;
        }
    }


    class Dado
    {
        private int valor { get; set; }
        private Random aleatorio;


        public Dado()
        {
            aleatorio = new Random();
        }


        public int Tirar()
        {
            valor = aleatorio.Next(1, 7);
            return valor;
        }


        public void MostrarValor()
        {
            Console.WriteLine("Te salio un: " + valor);
        }


        public int Valor
        {
            get { return valor; }
        }
    }
}