Ejeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
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


            int resultado = 0;
            foreach (int i in array)
                if(i < 0)
                {
                    resultado++;
                }

            

            Console.WriteLine("La cantidad de numeros negativos en el arreglo es:", resultado);

            Console.ReadKey();
        }
    }
}
