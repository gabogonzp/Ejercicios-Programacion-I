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
            int numero;
            int digito1 = 0;
            int digito2 = 0;
            int digito3 = 0;
            int digito4 = 0;

            Console.Write("Introduzca un numero entero de cuatro digitos:");
            numero = Convert.ToInt32(Console.ReadLine());

            digito1 = numero / 1000;
            digito2 = (numero/100)%10;
            digito3 = (numero / 10) % 10;
            digito4 = (numero % 10);

            if (digito2 == digito3)
                Console.WriteLine("El segundo y penultimo digitos son iguales.");
            else
                Console.WriteLine("El segundo y penultimo digitos no son iguales ");

            Console.ReadKey();



        }
        
    }
}
