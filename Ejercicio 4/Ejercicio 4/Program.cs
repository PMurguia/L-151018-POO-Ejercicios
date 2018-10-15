using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dame un peso en kilos. ");
            double peso = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿A qué lo pasamos? \nLb - Libras\nLi - Lingotes\nOz - Onzas\nP - Peniques\nK - Kilos\nGr - Gramos\nQ - Quintales");
            string tipo = Console.ReadLine();
            Peso p1 = new Peso(peso,tipo);

            p1.GetPesaje(peso, tipo);
            Console.ReadLine();


        }
    }
}
