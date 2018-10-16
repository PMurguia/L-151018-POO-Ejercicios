using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Consumo
    {
        private double kms;
        private double litros;
        private double vMed;
        private string combustible;
        

        public Consumo()
        {
            
        }

        public Consumo(double kms,double litros,double vMed,string combustible)
        {
            this.kms = kms;
            this.litros = litros;
            this.vMed = vMed;
            this.combustible = combustible;
        }

        public double GetKms()
        {
            return kms;
        }
        public void SetKms(double kms)
        {
            this.kms = kms;
        }

        public double GetLitros()
        {
            return litros;
        }
        public void SetLitros(double litros)
        {
            this.litros = litros;
        }

        public double GetVelocidadMedia()
        {
            return vMed;
        }
        public void SetVelocidadMedia(double vMed)
        {
            this.vMed = vMed;
        }

        public string GetCombustible()
        {
            return combustible;
        }
        public void SetCombustible(string combustible)
        {
            this.combustible = combustible;
        }



        public string GetTiempo()
        {
            return "Se ha realizado un viaje de " + kms + " kms, a una velocidad media de " + vMed + " Km/h.\nEl viaje ha tenido una duración media de  " + (kms / vMed) + " horas.";
        }

        public string GetConsumoMedio()
        {
            return "Ha consumido " + ((litros/kms)*100) + " litros cada 100 Kms.";
        }

        public string GetConsumoEuros()
        {
            if(combustible == "95")
            {
                return "El gasto total del viaje ha sido de " + (litros * 1.14) + " euros. ";
            }
            else if(combustible == "98")
            {
                return "El gasto total del viaje ha sido de " + (litros * 1.25) + " euros. ";
            }
            else if (combustible == "Diesel")
            {
                return "El gasto total del viaje ha sido de " + (litros * 1.04) + " euros. ";
            }
            else
            {
                return "No reconozco el tipo de combustible. ";
            }
        }

        public string MostrarDatos()
        {
            return kms + " kms recorridos \n" + litros + " litros consumidos \n" + "A una velocidad media de " + vMed + " Kms/h\nCon conmbustible de tipo " + combustible; 
        }

    }
}
