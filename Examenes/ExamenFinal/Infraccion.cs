using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgI
{
    public class Infraccion
    {
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public double Costo { get; set; }

        public Infraccion(string tipo, DateTime fecha, double costo)
        {
            Tipo = tipo;
            Fecha = fecha;
            Costo = costo;
        }






    }
}
