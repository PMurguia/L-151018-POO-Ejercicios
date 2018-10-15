using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Millas
    {
       private double distancia;
      

        public Millas()
        {
            
        }
        public Millas(double distancia)
        {
            this.distancia = distancia;
        }

        public double GetMillas()
        {
            return distancia;
        }
        public void SetMillas(double distancia)
        {
            this.distancia = distancia;
        }

        public void MillasAMetros(double distancia)
        {
            double metros = 1852;

            distancia = distancia * metros;
            
        }
        public double GetMillasAKilometros(double distancia)
        {
            double metros = 1852;
            return distancia = (distancia*metros)/1000;

        }
    }
}
