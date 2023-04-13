using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgI
{
    public class Agente
    {
        int costo;
        public int CodigoEmpleado { get; set; }
        public string NombreCompleto { get;  set; }
        public string Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Agente(int codigoEmpleado, string nombreCompleto, string direccion, DateTime fechaIngreso)
        {
            CodigoEmpleado = codigoEmpleado;
            NombreCompleto = nombreCompleto;
            Direccion = direccion;
            FechaIngreso = fechaIngreso;
        }


      
    }


}
