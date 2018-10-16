using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CFecha
    {
        private DateTime returnDia;
        private string diaRet, mesRet, yearRet;
        private int variablerandom, yearent, mesent, diaent, edad;


        public int DevolverDia()
        {
            //{ 
            DateTime dateValue = new DateTime(1990, 12, 10);
            diaRet = dateValue.ToString("dd");
            diaent = Convert.ToInt32(diaRet);
            return diaent;
        }
        public int DevolverMes()
        {
            //{ 
            DateTime dateValue = new DateTime(1990, 12, 10);
            mesRet = dateValue.ToString("MM");
            mesent = Convert.ToInt32(mesRet);
            return mesent;

        }
        public int DevolverYear()
        {
            //{ 
            DateTime dateValue = new DateTime(1990, 12, 10);
            yearRet = dateValue.ToString("yyyy");
            yearent = Convert.ToInt32(yearRet);
            return yearent;

        }


       
        //public void Felicitar()
        //{
        //    System.Console.WriteLine("Felicidades en tus " + ObtenerEdad() + " años");
        //    System.Console.ReadLine();
        //}



        //DevolverMes
        //DevolverYear
    }
}

