using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Peso
    {
        private double peso;
        private string tipo;

        public Peso(double peso, string tipo)
        {
            this.peso = peso;
            this.tipo = tipo;
        }

        public double GetPeso()
        {
            return peso;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }


        public double GetPesaje(double peso, string tipo)
        {
            double lb = 2.20462;
            double li = 0.0685;
            double oz = 35.274;
            double p = 645.16;
            double k = 1;
            double gr = 1000;
            double q = 0.01;
            if (tipo == "Lb")
            {
                Console.WriteLine("Eso son " + (peso*lb) + " libras.");
            }
            else if (tipo == "Li")
            {
                Console.WriteLine("Eso son " + (peso * li) + " lingotes.");
            }
            else if (tipo == "Oz")
            {
                Console.WriteLine("Eso son " + (peso * oz) + " onzas.");
            }
            else if (tipo == "P")
            {
                Console.WriteLine("Eso son " + (peso * p) + " peniques ( PEROQUE CLASE DE MEDIDA DE MASA ES UN PENIQUE, A VER). ");
            }
            else if(tipo == "K")
            {
                Console.WriteLine("Eso son " + (peso * k) + " kilos.");
            }
            else if(tipo == "Gr")
            {
                Console.WriteLine("Eso son " + (peso * gr) + " gramos.");
            }
            else if(tipo == "Q")
            {
                Console.WriteLine("Eso son " + (peso * q) + " quintales.");
            }
            else
            {
                Console.WriteLine("No reconozco esa masa. ");
            }
            return peso;
        }
        public double GetLibras(double peso)
        {
            double lb = 2.20462;
            return (peso * lb);
        }
        public double GetLingotes(double peso)
        {
            double li = 0.0685;
            return (peso * li);
        }
    }
}
