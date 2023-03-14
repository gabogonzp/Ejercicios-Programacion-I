using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCentralita
{
    public class Llamada
    {
     
        public string NumOrigen { get; set; }

        public string NumDestino { get; set; }

        public string Duracion { get; set; }

        public Llamada(string numOrigen, string numDestino)
        {
            NumOrigen = numOrigen;
            NumDestino = numDestino;
            
        }


        public int calcularTiempo(int edad)
        {
            int tiempo = edad * 3;
            return tiempo;
        }


       

    }
}
