using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Contacto2
    {
        //private int fecha, mes, year, dia;
        private DateTime fechaNacimiento;
        private string nombre, tipoContacto;
        private int edad, telefono;
        private static int nContactos = 0,nFamiliares, nAmigos, nTrabajo, nEstudios;
      

        public Contacto2()
        {
            
        }

        public Contacto2(string nombre, DateTime fechaNacimiento, string tipoContacto)
        {

            this.nombre = nombre;
            
            Contacto(tipoContacto);

            DateTime oldDate = fechaNacimiento;
            DateTime newDate = DateTime.Now;
            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;
            // Difference in days.
            int differenceInYears = ts.Days / 365;

            if (differenceInYears <= 110)
            {

                this.fechaNacimiento = fechaNacimiento;
          

            }
            else
            {
                Console.WriteLine("Fecha erronea");
            }
            this.tipoContacto = tipoContacto;
        }

        public Contacto2(string nombre, DateTime fechaNacimiento)
        {

            this.nombre = nombre;
            nContactos++;
            nAmigos++;
            tipoContacto = "AMIGOS";
            
            Console.WriteLine("Contacto amigo agregado.");
            

            DateTime oldDate = fechaNacimiento;
            DateTime newDate = DateTime.Now;
            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;
            // Difference in days.
            int differenceInYears = ts.Days / 365;

            if (differenceInYears <= 110)
            {

                this.fechaNacimiento = fechaNacimiento;
                

            }
            else
            {
                Console.WriteLine("Fecha erronea");
            }
        }

        public Contacto2(string nombre, int telefono, string tipoContacto)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = DateTime.Today;
            Contacto(tipoContacto);
            this.tipoContacto = tipoContacto;
           
            
        }

        //set get
        public string GetTipoContacto()
        {
            return this.tipoContacto;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetTelefono()
        {
            return this.telefono;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetTipoContacto(string tipoContacto)
        {
            Contacto(tipoContacto);
            this.tipoContacto = tipoContacto;

        }

        //metodos

        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string DevolverNombre(string nombre)
        {
            return this.nombre;
        }

        public void CambiarTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public int DevolverTelefono(int telefono)
        {
            return this.telefono;
        }

        public int ObtenerEdad()
        {

            DateTime oldDate = fechaNacimiento;
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;

            // Difference in days.
            edad = (ts.Days / 365);
            return edad;
        }

        public void Felicitar()
        {
            System.Console.WriteLine("Felicidades en tus " + ObtenerEdad() + " años");

        }

        public string MostrarDatos()
        {

            return (GetNombre() + " " + GetTelefono() + " " + GetFechaNacimiento() + " " + GetTipoContacto());
        }

        public void Contactos(string tipoContacto)
        {
            //int nFamiliares = 0, nAmigos = 0, nTrabajo = 0, nEstudios = 0;

           
            const string iFamiliares = "FAMILIARES", iAmigos = "AMIGOS", iTrabajo = "TRABAJO", iEstudios = "ESTUDIOS";
            //if(tipoContacto==null)
            //{
            //    tipoContacto = "0";
            //}


            switch (tipoContacto.ToUpper())
            {
                case iFamiliares:
                    nFamiliares++;

                    Console.WriteLine("Contacto familiares agregado.");
                    break;

                case iAmigos:
                    nAmigos++;

                    Console.WriteLine("Contacto amigo agregado.");
                    break;

                case iTrabajo:

                    nTrabajo++;
                    Console.WriteLine("Contacto trabajo agregado.");

                    break;

                case iEstudios:

                    nEstudios++;
                    Console.WriteLine("Contacto estudios agregado.");

                    break;

                default:

                    nAmigos++;
                    Console.WriteLine("Contacto amigo agregado.");

                    break;

            }
            nContactos++;


        }

        public void Contador()
        {
          
            Console.WriteLine("número de contactos totales :" + nContactos);
            Console.WriteLine("Numero de contactos amigo: " + nAmigos);
            Console.WriteLine("Numero de contactos familia: " + nFamiliares);
            Console.WriteLine("Numero de contactos trabajo: " + nTrabajo);
            Console.WriteLine("Numero de contactos estudios: " + nEstudios);



        }

        //public void ConvertirFecha()
        //{
        //    fecha = GetFechaNacimiento();



        //    year = fecha / 10000; //año
        //    mes = (fecha % 10000 - (fecha % 100)) / 100; // mes
        //    dia = fecha % 100; //dia
        //    Console.WriteLine(year + "," + mes + "," + dia);

        //    //Console.WriteLine("dia es " + dia + " mes " + mes + " año " + year);
        //    Console.ReadLine();
        //}

    }
}
