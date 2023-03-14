using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCentralita
{
    public class Llamadalocal : Llamada 
    {
        public Llamadalocal(string numOrigen, string numDestino) : base(numOrigen, numDestino)
        {
        }

        public int calcularTiempo(int edad)
        {
            int tiempo = edad * 3;
            return tiempo;
        }

        public int calcularPrecio(int tiempo)
        {
            int precio = tiempo * 15;
            return precio;
        }

        


    }
}
