using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marca de coche. ");
            string marca = Console.ReadLine();
            Console.WriteLine("Modelo. ");
            string modelo = Console.ReadLine();
            Coche c1 = new Coche();
            c1.SetMarca(marca);
            c1.SetModelo(modelo);

            
            Console.ReadLine();

        }
    }
}
