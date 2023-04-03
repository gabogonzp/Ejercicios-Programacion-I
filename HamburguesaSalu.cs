using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimiDeBilly
{
    class HamburguesaSalu : Hamburguesa
    {
        private string ingrediente1;
        private string ingrediente2;

        public HamburguesaSalu(string tipoCarne, int precioBase) : base("Integral", tipoCarne, precioBase)
        {
        }

        public void AgregarIngredientes(string ingrediente1, string ingrediente2, int precio1, int precio2)
        {
            this.ingrediente1 = ingrediente1;
            this.ingrediente2 = ingrediente2;
           // AgregarAdicional(ingrediente1, precio1);
           // AgregarAdicional(ingrediente2, precio2);
        }
    }

}
