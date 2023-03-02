using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class PracticaPOO
    {
        static void Main(string[] args)
        {
            Garaje garaje = new Garaje();

            
            Coche coche1 = new Coche("Toyota", "Highlander");
            Coche coche2 = new Coche("Hyundai", "Cantus");

            Garaje.aceptarCoche(coche2);
            Garaje.moverCoche(coche2);
            Garaje.aceptarCoche(coche1);
            Garaje.moverCoche(coche1);
            Garaje.aceptarCoche(coche2);
            Garaje.moverCoche(coche2);
            Garaje.aceptarCoche(coche1);
            Garaje.moverCoche(coche1);


            Console.ReadKey();
           

            

        }
    }
}
