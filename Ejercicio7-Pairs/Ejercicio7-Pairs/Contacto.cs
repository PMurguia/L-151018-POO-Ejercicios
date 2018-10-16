using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Contacto
    {
        private DateTime fechaNacimiento;
        private string nombre;
        private int edad, telefono;
        private int fecha, mes, year, dia;

        public Contacto()
        {

        }

        public Contacto(string nombre, DateTime fechaNacimiento)
        {
            
            this.nombre = nombre;

            DateTime oldDate = fechaNacimiento;
            DateTime newDate = DateTime.Now;
            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;
            // Difference in days.
            int differenceInYears = ts.Days / 365;

            if (differenceInYears <= 110)
            {

                this.fechaNacimiento = fechaNacimiento;
                Console.WriteLine(this.fechaNacimiento);
                
            }
            else
            {
                Console.WriteLine("Fecha erronea");
            }
        }

        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = DateTime.Today;
        }

        //set get

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
            System.Console.ReadLine();
        }

        public string MostrarDatos()
        {

            return (GetNombre() + " " + GetTelefono() + " " + GetFechaNacimiento());
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
