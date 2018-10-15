using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame millas que las paso a kilómetros. ");
            double distancia = Int32.Parse(Console.ReadLine());
            Millas m1 = new Millas();

            Console.WriteLine(m1.GetMillasAKilometros(distancia) + " kilómetros.");
            Console.ReadLine();
        }
    }
}
