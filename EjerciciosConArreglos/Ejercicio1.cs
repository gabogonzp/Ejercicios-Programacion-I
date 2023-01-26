using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca diez numeros enteros");
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            int max = array.Max();
            int index = Array.IndexOf(array, max);
            Console.WriteLine("El numero mayor en el arreglo esta en la posicion:"+ index );

      
            Console.ReadKey();
        }

        
    }
}
