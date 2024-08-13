using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_poo.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero{ get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        public void Ligar()
        {
            System.Console.WriteLine("Recebendo ligação");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}