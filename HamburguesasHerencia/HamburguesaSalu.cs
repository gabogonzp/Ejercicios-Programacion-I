using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimiDeBilly
{
    class HamburguesaSalu : Hamburguesa
    {
       
        public HamburguesaSalu(string tipoCarne, int precioBase) : base("Integral", tipoCarne, precioBase)
        {
        }

        public  string[] thisingredientesExtras = { "lechuga", "tomate", "cebolla", "pepinillos","bacon","salsa bbq" };
        private bool[] thisingredientesSeleccionados = { false, false, false, false, false, false };
        private double[] thispreciosIngredientes = { 0.5, 0.3, 0.4, 0.6, 0.6, 0.3 };

        public override void SeleccionarIngrediente(int opcion)
        {


            if (opcion >= 1 && opcion <= 6)
            {
                int indice = opcion - 1;
                thisingredientesSeleccionados[indice] = true;
                Console.WriteLine($"\nSe ha agregado {thisingredientesExtras[indice]} a la hamburguesa.");
            }
            else
            {
                Console.WriteLine("\nOpción inválida. Por favor, seleccione una opción del 1 al 4.");
            }


        }

        public void CalcularCosto()
        {
            double costoTotal = precioBase;

            for (int i = 0; i < thisingredientesSeleccionados.Length; i++)
            {
                if (thisingredientesSeleccionados[i])
                {
                    costoTotal += thispreciosIngredientes[i];
                    Console.WriteLine($"El ingrediente extra {thisingredientesExtras[i]} cuesta {thispreciosIngredientes[i]}.");
                }
            }

            Console.WriteLine($"\nEl precio total de la hamburguesa es: \nPrecio base:{precioBase} \nPrecio ingredientes{preciosIngredientes} \nCosto final:{costoTotal}.");
        }
    }
}


