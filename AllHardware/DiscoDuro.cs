using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class DiscoDuro
    {
        string Marca;
        string Interfaz;
        string Capacidad;
        string Tipo_de_Disco_Duro;

        public void MostarDiscoDuros(string Marca, string Interfaz, string Capacidad, string Tipo_de_Disco_Duro)
        {
            Console.WriteLine("La Marca del disco duro es: Western Digital" + Marca);
            Console.WriteLine(" La Interfaz es: SATA 3 " + Interfaz);
            Console.WriteLine("La Capacidad es: 2TB " + Capacidad);
            Console.WriteLine("Que Tipo de Disco duro es: HDD" + Tipo_de_Disco_Duro);        
        }



    }
}
