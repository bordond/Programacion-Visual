using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_160921
{
    public class Program
    {
        static void Main(string[] args)
        {
            Asistente asistente1 = new Asistente(1,"Diego","Bordon",3000,3,54);
            asistente1.HoraSueldo();
            Console.ReadKey();
        }
     }
}
