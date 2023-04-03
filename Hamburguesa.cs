using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimiDeBilly
{
    public class Hamburguesa
    {
        
            private string tipoPan;
            private string tipoCarne;
            private double precioBase;
            public string[] ingredientesExtras = { "lechuga", "tomate", "cebolla", "pepinillos" };
            private bool[] ingredientesSeleccionados = { false, false, false, false };
            private double[] preciosIngredientes = { 0.5, 0.3, 0.4, 0.6 };

            public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
            {
                this.tipoPan = tipoPan;
                this.tipoCarne = tipoCarne;
                this.precioBase = precioBase;
            }

            public void SeleccionarIngrediente(int opcion)
            {

                for (int i = 0; i < 4; i++) {
                if (opcion >= 1 && opcion <= 4)
                {
                    int indice = opcion - 1;
                    ingredientesSeleccionados[indice] = true;
                    Console.WriteLine($"Se ha agregado {ingredientesExtras[indice]} a la hamburguesa.");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción del 1 al 4.");
                }
            }
                
            }

            public void CalcularCosto()
            {
                double costoTotal = precioBase;

                for (int i = 0; i < ingredientesSeleccionados.Length; i++)
                {
                    if (ingredientesSeleccionados[i])
                    {
                        costoTotal += preciosIngredientes[i];
                        Console.WriteLine($"El ingrediente extra {ingredientesExtras[i]} cuesta {preciosIngredientes[i]}.");
                    }
                }

                Console.WriteLine($"El precio total de la hamburguesa es: {costoTotal}.");
            }
        }
    }

