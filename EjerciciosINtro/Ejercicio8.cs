using System;
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
            int number = 0;
            bool state = false;
            while (state == false)
            {
                Console.WriteLine("Escriba un numero de 5 digitos: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 10000 & Number <= 99999)
                {
                    number = Number;
                    state = true;
                }
                else
                {
                    Console.WriteLine($"{Number} no es numero de 5 digitos.");
                    Console.WriteLine("");
                }
            }
            int digit1 = number / 10000;
            int digit2 = (number % 10000) / 1000;
            int digit4 = (number % 100) / 10;
            int digit5 = number % 10;

            if (digit1 == digit5 & digit2 == digit4)
            {
                Console.WriteLine("");
                Console.WriteLine($"{number} si es un numero capicua!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{number} no es un numero capicua.");
            }
        }
    }
}
