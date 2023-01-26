using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
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
                resultado += i;

            int promedio = resultado / (array.Length);

            Console.WriteLine("El promedio entero de los elementos es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
