using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCentralita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Elija que tipo de llamada desea realizar: \n1.Local \n2.Provincial \n3.Ver registro de llamadas");
            int ele = Convert.ToInt32(Console.ReadLine());

            if (ele == 1)
            {
                Llamadalocal llamada = new Llamadalocal("809","829");

                Console.WriteLine($"Tiempo de llamada:{llamada.calcularTiempo(8)} segundos");
                Console.WriteLine($"Precio de la llamada: {llamada.calcularPrecio(llamada.calcularTiempo(8))} pesos");
                Console.ReadKey();
            }

            if (ele == 2)
            {
                
                Console.WriteLine($"Elija la franja horaria de su llamada. \n 1, 2, o 3");
                int franja = Convert.ToInt32(Console.ReadLine());
                Llamadaprovincial llamada = new Llamadaprovincial("809", "829");

                Console.WriteLine($"El precio de su llamada para la franja seleccionada es de {llamada.CalcularPrecio(llamada.calcularTiempo(8), franja)} pesos");
                Console.ReadKey();
            }

            if (ele == 3)
            {
                Centralita centralita = new Centralita("809", "829");

                Centralita.AgregarLista();
                
            }




        }
    }
}
