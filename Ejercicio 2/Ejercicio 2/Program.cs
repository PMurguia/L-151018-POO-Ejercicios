using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero();

            Console.WriteLine("Añadimos un número al valor interno y nos da: " + n1.Aniade());
            Console.WriteLine("Restamos un número al valor interno y nos da: " + n1.Resta());
            Console.WriteLine("Nos da el valor del número interno: " + n1.GetValor());
            Console.WriteLine("Nos devuelve el doble del valor interno: " + n1.GetDoble());
            Console.WriteLine("Nos devuelve el triple del valor interno: " + n1.GetTriple());

            Console.ReadLine();
        }
    }
}
