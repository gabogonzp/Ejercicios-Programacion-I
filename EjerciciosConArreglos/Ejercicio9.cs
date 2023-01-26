using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca diez numeros enteros:");
            int[] array = new int[10];
            int[] arrayfactorial = new int[10];

            int j = 0; int w = 0; int v = 0;

            for (int i = 0; i <=9; i++)
            {
                int n = int.Parse(Console.ReadLine());
                array[i]=factorial(n);
            }

            Console.WriteLine(string.Join(",", array));



            int factorial(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }

                return fact;
            }




            
            Console.ReadKey();
        }
    }
}
