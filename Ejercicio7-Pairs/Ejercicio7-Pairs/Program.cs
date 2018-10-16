using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(1990,2,4);
            DateTime f = new DateTime(1992, 2, 4);
            DateTime g = new DateTime(1995, 05, 05);

            Contacto c1 = new Contacto();
            Contacto c2 = new Contacto("jon", 931212123);
            Contacto c3 = new Contacto("ane", d);
            Contacto c4 = new Contacto();
            c1.SetNombre("Miren");
            c1.SetTelefono(944123456);
            c1.SetFechaNacimiento(g);

            c4.SetNombre("Julen");
            c4.SetTelefono(944123321);
            c4.SetFechaNacimiento(f);


            Console.WriteLine(c1.MostrarDatos());
            Console.WriteLine(c2.MostrarDatos());
            Console.WriteLine(c3.MostrarDatos());
            Console.WriteLine(c4.MostrarDatos());

            Console.WriteLine(c1.ObtenerEdad());
            Console.WriteLine(c2.MostrarDatos());
            Console.WriteLine(c3.MostrarDatos());
            Console.WriteLine(c4.MostrarDatos());

            //c1.ConvertirFecha();

            Contacto f1 = new Contacto();
            f1.Felicitar();







            Console.ReadLine();




        }
    }
}
