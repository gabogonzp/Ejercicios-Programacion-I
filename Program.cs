using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ciclo = true;

            while (ciclo)
            {
                Console.WriteLine($"///Que raza de perro desea elegir?\n1) Chihuahua  2) Bulldog  3)Salir");
                Console.Write("///Digite su opcion:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Chihuahua chihuahua = new Chihuahua();

                    Console.WriteLine($"\n///En esta el los chihuahua:");

                    Console.WriteLine(chihuahua.Ladrar());

                    Console.WriteLine(chihuahua.Correr());

                    Console.WriteLine(chihuahua.Comer());

                    Console.WriteLine(chihuahua.Kgar());

                    Console.WriteLine(chihuahua.Dormir());
                }

                if (opcion == 2)
                {
                    Bulldog bulldog = new Bulldog();

                    Console.WriteLine($"\nEn esto esta el bulldog:");

                    Console.WriteLine(bulldog.Ladrar());

                    Console.WriteLine(bulldog.Correr());

                    Console.WriteLine(bulldog.Comer());

                    Console.WriteLine(bulldog.Kgar());

                    Console.WriteLine(bulldog.Dormir());
                }

                if (opcion == 5)
                {
                    Console.WriteLine("Ya usted no quiere saber de perro.");
                    ciclo = false;
                }
            }

 
                Console.ReadKey();

            
        }
        }
    }

