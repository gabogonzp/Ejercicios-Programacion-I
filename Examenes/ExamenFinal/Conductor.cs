using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgI
{
    internal class Conductor
    {
        public string NombreCompleto { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public int TipoLicencia { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Conductor(string nombreCompleto, int cedula, string direccion, int tipoLicencia, DateTime fechaNacimiento)
        {
            NombreCompleto = nombreCompleto;
            Cedula = cedula;
            Direccion = direccion;
            TipoLicencia = tipoLicencia;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
