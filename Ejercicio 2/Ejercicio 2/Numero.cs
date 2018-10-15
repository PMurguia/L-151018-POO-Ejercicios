using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Numero
    {
        private int numero;
                       
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(int numero)
        {
            this.numero = numero++;
        }

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }


        public int Aniade()
        {
            return numero+1;
        }

        public int Resta()
        {
           return numero-1;
        }

        public int GetValor ()
        {
            return this.numero;
        }

        public int GetDoble ()
        {
            return (this.numero * 2);
        }

        public int GetTriple ()
        {
            return (this.numero * 3);
        }

        public void SetNum (int numero)
        {
            this.numero = numero;
        }
    }

}
