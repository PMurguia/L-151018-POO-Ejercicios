using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactoTipo;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(1990,2,4);
            DateTime f = new DateTime(1992, 2, 4);
            DateTime g = new DateTime(1995, 05, 05);
            DateTime h = new DateTime(1990, 03, 06);
            DateTime i = new DateTime(1992, 2, 12);
            DateTime j = new DateTime(1992, 6, 6);
            DateTime k = new DateTime(1997, 7, 7);

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
            Console.WriteLine(c2.ObtenerEdad());
            Console.WriteLine(c3.ObtenerEdad());
            Console.WriteLine(c4.ObtenerEdad());

            c1.Felicitar();
            c2.Felicitar();
            c3.Felicitar();
            c4.Felicitar();

            Contacto2 co1 = new Contacto2();
            co1.SetNombre("Miren");
            co1.SetTelefono(944123456);
            co1.SetFechaNacimiento(h);
            co1.SetTipoContacto("AMIGOS");

            Contacto2 co2 = new Contacto2("Jon",931212123);
            Contacto2 co3 = new Contacto2("Ane", g, "FAMILIARES");

            Contacto2 co4 = new Contacto2();
            co4.SetNombre("Julen");
            co4.SetTelefono(944123456);
            co4.SetFechaNacimiento(i);
            co4.SetTipoContacto("estudios");

            Contacto2 co5 = new Contacto2("Jone", j);
            Contacto2 co6 = new Contacto2("Mikel", k, "FAMILIARES");


            co1.Contador();


            //c1.ConvertirFecha();

            //Contacto f1 = new Contacto();
            //f1.Felicitar();

            Console.WriteLine(co1.MostrarDatos());
            Console.WriteLine(co2.MostrarDatos());
            Console.WriteLine(co3.MostrarDatos());
            Console.WriteLine(co4.MostrarDatos());
            Console.WriteLine(co5.MostrarDatos());
            Console.WriteLine(co6.MostrarDatos());




            Console.ReadLine();




        }
    }
}
