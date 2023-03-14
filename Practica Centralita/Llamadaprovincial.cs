using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCentralita
{
    class Llamadaprovincial : Llamada
    {
        public Llamadaprovincial(string numOrigen, string numDestino) : base(numOrigen, numDestino)
        {
        }

        public int CalcularPrecio(int tiempo, int franja)
        {
            int precio = 0;

            if (franja == 1)
            {
                
               precio = tiempo * 15;
               return precio;
                
            }


            if (franja == 2)
            {

                precio = tiempo * 25;
                return precio;

            }


            if (franja == 3)
            {

                precio = tiempo * 30;
                return precio;

            }

            return precio;




        }


    }
}
