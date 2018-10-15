using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Coche
    {
        private string marca;
        private string modelo;

        public Coche()
        {
            
        }

        public Coche(string marca,string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string AtributosCoche(string marca, string modelo)
        {

            return AtributosCoche(marca, modelo);
        }



    }
}
