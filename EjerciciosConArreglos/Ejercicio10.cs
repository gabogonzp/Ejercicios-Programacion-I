using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int contador = 0;
            

            Console.WriteLine("Introduzca dies numeros enteros:");

            for (int i=0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Introduzca un numero entero para buscar divisores exactos: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            foreach (int i in array)
            {
                if ((numero%i)==0)
                {
                    contador++;
                }
            }

            Console.WriteLine("El numero {0} tiene {1} divisores exactos dentro del arreglo",numero,contador);

            Console.ReadKey();


            



        }
    }
}
