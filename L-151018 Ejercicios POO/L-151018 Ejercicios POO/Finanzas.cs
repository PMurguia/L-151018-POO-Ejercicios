using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_151018_Ejercicios_POO
{
    class Finanzas
    {
        private double cantidad;

        public Finanzas()
        {

        }

        public Finanzas(double cantidad)
        {
            this.cantidad = cantidad;
        }
       

        public double GetEuros()
        {
            return euros;
        }
        public void SetEuros(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public void dolaresToEuros(double cantidad)
        {
            return cantidad / 1.16;
        }


    }


}
