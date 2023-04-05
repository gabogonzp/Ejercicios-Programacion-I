using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimiDeBilly
{
    public class Hamburguesa
    {
        
            public string tipoPan;
            public string tipoCarne;
            public double precioBase;
            public string[] ingredientesExtras = { "lechuga", "tomate", "cebolla", "pepinillos" };
            public bool[] ingredientesSeleccionados = { false, false, false, false };
            public double[] preciosIngredientes = { 0.5, 0.3, 0.4, 0.6 };

            public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
            {
                this.tipoPan = tipoPan;
                this.tipoCarne = tipoCarne;
                this.precioBase = precioBase;
            }

            public virtual void SeleccionarIngrediente(int opcion)
            {

             
                if (opcion >= 1 && opcion <= 4)
                {
                    int indice = opcion - 1;
                    ingredientesSeleccionados[indice] = true;
                    Console.WriteLine($"\nSe ha agregado {ingredientesExtras[indice]} a la hamburguesa.");
                }
                else
                {
                    Console.WriteLine("\nOpción inválida. Por favor, seleccione una opción del 1 al 4.");
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

                Console.WriteLine($"\nEl precio total de la hamburguesa es: \nPrecio base:{precioBase} \nPrecio ingredientes{preciosIngredientes} \nCosto final:{costoTotal}.");
            }
        }
    }

