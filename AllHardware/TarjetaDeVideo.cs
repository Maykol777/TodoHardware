using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class TarjetaDeVideo
    {
        string Fabricante;
        string Modelo;
        string Memoria;
        string TipoDeMemoria;

        
        public void ValorTDV(string Fabricante,string Modelo, string Memoria, string TipoDeMemoria)
        {
            Console.WriteLine("Fabricante: " + Fabricante + " Modelo: " + Modelo);
            Console.WriteLine("Memoria: " + Memoria + " Tipo de memoria: " + TipoDeMemoria);
        }

    }
}
