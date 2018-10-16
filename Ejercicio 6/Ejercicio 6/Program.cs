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

            
            
            Coche c1 = new Coche();
            c1.SetMarca("Alfa Romeo");
            c1.SetModelo("Giulietta");

            Console.WriteLine(c1.GetAtributosCoche());
            Console.ReadLine();


            Consumo consumo1 = new Consumo();
            consumo1.SetKms(378);
            consumo1.SetLitros(43);
            consumo1.SetVelocidadMedia(175);
            consumo1.SetCombustible("Diesel");

            Console.WriteLine("DATOS DE VIAJE.");

            Console.WriteLine(consumo1.GetTiempo());
            Console.WriteLine();
            Console.WriteLine(consumo1.GetConsumoMedio());
            Console.WriteLine();
            Console.WriteLine(consumo1.GetConsumoEuros());
            Console.WriteLine();
            Console.WriteLine(consumo1.MostrarDatos());

            Console.ReadLine();


            Coche c2 = new Coche("Volkswagen", "Golf R32");
            Console.WriteLine(c2.GetAtributosCoche());
            Console.ReadLine();
            Console.WriteLine("Introduce kilómetros totales del viaje: ");
            double kms = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce litros consumidos: ");
            double litros = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce velocidad media durante el trayecto.");
            double vMed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de combustible utilizado:\n95-Gasolina 95\n98-Gasolina 98\nDiesel-Diesel");
            string combustible = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("DATOS DE VIAJE");
            Consumo consumo2 = new Consumo(kms, litros, vMed, combustible);
            Console.WriteLine(consumo2.GetTiempo());
            Console.WriteLine();
            Console.WriteLine(consumo2.GetConsumoMedio());
            Console.WriteLine();
            Console.WriteLine(consumo2.GetConsumoEuros());
            Console.WriteLine();
            Console.WriteLine(consumo2.MostrarDatos());
            Console.ReadLine();
        }
    }
}
