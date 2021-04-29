using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class PlacaBase
    {
        string Marca;
        string Plataforma;
        string Factor_de_forma;
        string Socket;
        string Chipset;
        string Tipo_de_memoria;
        int Slots_de_memoria;
        string Maximo_de_memoria;
       
        
       

        public void InfoPlaca(string Marca, string Plataforma, string Factor_de_forma,
            string Socket, string Chipset, string Tipo_de_memoria, int Slots_de_memoria, string Maximo_de_memoria)
        {
            Console.WriteLine("La marca es: Asus " + Marca, "La plataforma es: AMD " + Plataforma); 
                Console.WriteLine("El Factor de forma es: ATX" + Factor_de_forma);
            Console.WriteLine(" El Socket es: Socket AM4 " + Socket, " El Chipset es: X570 " + Chipset);
            Console.WriteLine(" El tipo de Memoria es: DDR4 DIMM " + Tipo_de_memoria);
            Console.WriteLine("El Slots de memoria es de: 4 " + Slots_de_memoria );
            Console.WriteLine("El Maximo de memoria es: 128 GB " + Maximo_de_memoria);
        }

        
    }
   
}
