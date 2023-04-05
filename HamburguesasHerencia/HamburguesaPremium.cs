using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimiDeBilly
{
    class HamburguesaPremium : Hamburguesa
    {

        public string[] thisingredientesExtras = { "Papitas", "Bebida"};
        private double[] thispreciosIngredientes = { 1, 1.5};

        public HamburguesaPremium(string tipoPan,string tipoCarne) : base( tipoPan, tipoCarne, 300  )
        {
   
        }

       
        public void CalcularCosto()
        {
            double costoTotal = precioBase;

          
                {
                    costoTotal += thispreciosIngredientes[0];
                    costoTotal += thispreciosIngredientes[1];

                Console.WriteLine($"El ingrediente {thisingredientesExtras[0]} cuesta {thispreciosIngredientes[0]}. \nEl ingrediente {thisingredientesExtras[1]} cuesta {thispreciosIngredientes[1]}.");
                }
           

            Console.WriteLine($"\nEl precio total de la hamburguesa es: \nPrecio base:{precioBase} \nPrecio ingredientes{preciosIngredientes} \nCosto final:{costoTotal}.");
        }
    }
}
