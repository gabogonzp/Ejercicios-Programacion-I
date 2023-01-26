using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca diez numeros enteros");
            int[] array = new int[10];
            int[] arraypar = new int[10];
            int[] arrayprimo = new int[10];
            int j = 0; int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)

                    arraypar[j] = array[i];
                else

                    arrayprimo[k] = array[i];


            }


            int max = arrayprimo.Max();
            int index = Array.IndexOf(array, max);
            Console.WriteLine("El numero primo mayor en el arreglo esta en la posicion:" + index);


            Console.ReadKey();

        }
    }
}
