using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Introduzca diez numeros enteros");
            int[] array = new int[10];
            int[] arraypar = new int[10];
            
            int j = 0; 

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for (int i = 0; i< array.Length; i++)
            {
                if (array[i] % 2 == 0)

                 arraypar[j] = array[i]; 
                
                
            }


            int max = arraypar.Max();
            int index = Array.IndexOf(array, max);
            Console.WriteLine("El numero par mayor en el arreglo esta en la posicion:" + index);


            Console.ReadKey();

        }
    }
}

