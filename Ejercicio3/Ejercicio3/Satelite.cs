using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;

        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }

        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + " Meridiano "+ meridiano +" a una distancia de la tierra de "+distancia_tierra+" Kilómetros");
            Console.ReadLine();
        }


        //Métodos

        public void VariaAltura (double desplazamiento)
        {
            if(desplazamiento < 0)
            {
                Console.WriteLine("Satélite acercándose a la tierra. ");

            }
            else if (desplazamiento == 0)
            {
                Console.WriteLine("Satélite en paralelo a la Tierra. ");
            }
            else
            {
                Console.WriteLine("Satélite alejándose de la Tierra. ");
            }
        }

        public Boolean EnOrbita()
        {
            if (!EnOrbita())
            {
                return false;
            }
            else
            {
                return true;
            }  
        
        }

        public void VariaPosicion (double variap, double variam)
        {
            this.meridiano += variam;
            this.paralelo += variap;
        }
    }

}
