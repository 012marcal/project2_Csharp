using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Models
{
    public abstract class Smartphone
    {
        
        public string Numero { get; set; }
        protected string Modelo;
        protected string Imei;
        protected int Memoria;


        public Smartphone()
        {

        }

        public Smartphone(string numero,  string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        

        public void Ligar()
        {
            Console.WriteLine("Fazendo ligação");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Numero {Numero} Recebendo Ligação");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}