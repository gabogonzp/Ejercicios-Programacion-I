using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimiDeBilly
{
    class HamburguesaPremium : Hamburguesa
    {
        public HamburguesaPremium(string tipoCarne, int precioBase) : base("Tradicional", tipoCarne, precioBase  )
        {
            AgregarAdicional("Papitas", 2);
            AgregarAdicional("Bebida", 1);
        }

        public new void AgregarAdicional(string ingrediente, int precio)
        {
            Console.WriteLine("No se permiten ingredientes adicionales en una Hamburguesa Premium");
        }
    }
}
