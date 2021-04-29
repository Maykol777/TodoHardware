using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Procesador
    {
        string Modelo;
        string Zocalo;
        int Nucleos;
        int Hilos;
        string Frecuencia_De_Reloj;

        public void MostrarProc(string Modelo,string Zocalo,int Nucleos,int Hilos,string Frecuencia_De_Reloj)
        {
            Console.WriteLine("Modelo: " + Modelo + " Con Zocalo compatible: " + Zocalo);
            Console.WriteLine("Cantidad de nucleos: " + Nucleos);
            Console.WriteLine("Cantidad de Hilos: "+ Hilos);
            Console.WriteLine("Con una Frecuencia de Reloj Base de: "+Frecuencia_De_Reloj);

        }

    }
}
