using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Models
{
    public class Nokia : Smartphone
    {

        public Nokia() 
        {

        }

        public Nokia(string numero,  string modelo, string imei, int memoria) : base(numero ,modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no Smartphone Nokia!"); 
        }
    }
}