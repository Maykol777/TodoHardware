using AllHardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program 
    {
        static void Main(string[] args)
        {
            Procesador proc1 = new Procesador();
            Console.WriteLine("Los procesadores actuales son: ");
            Console.WriteLine("");
            proc1.MostrarProc("Intel I3-8800", "FCLGA1151", 4, 4, "2.3Ghz");

            Console.WriteLine("");

            Procesador proc2 = new Procesador();
            proc1.MostrarProc("AMD Ryzen 5 2600", "AM4",6,6,"3,4Ghz");

            Console.WriteLine();

            TarjetaDeVideo grafica = new TarjetaDeVideo();
           grafica.ValorTDV("ASUS", "Radeon RX 5600 XT", "6GB", "GDDR6");


            
            

            Console.ReadLine();
        }
        
    }
}
