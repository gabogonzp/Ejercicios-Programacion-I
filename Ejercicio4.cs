using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca diez numeros enteros");
            int[] array = new int[10];
            int[] arrayprimeros = new int[10];
            ;

            int j=0;

            for ( int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            }


            for ( int i = 0; i < array.Length; i++)
            {
                int firstdigit = (int)(array[i] / Math.Pow(10, (int)Math.Log10(array[i])));
                if (isPrime(firstdigit))
                {
                    j++;
                }
            }

            Console.WriteLine("Hay {0} primeros digitos primos en el arreglo", j);

            

             bool isPrime(int n)
            {
                if (n < 2)
                {
                    return false;
                }

                for (int i=2; i<=Math.Sqrt(n); i++)
                {
                    if (n%i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }


            Console.WriteLine(arrayprimeros[j]);
            Console.ReadKey();
        }


    }
}
