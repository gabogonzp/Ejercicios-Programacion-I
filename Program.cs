using System.Globalization;

namespace ChimiDeBilly
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("//Bienvenido al puesto de Chimi de Billy//");
            Console.WriteLine($"Ofrecemos tres tipos de hamburguesa, cual quiere probar?\n1)Hamburguesa Classic\n2)Hamburguesa Saludable\n3)Hamburguesa Premium\nDigite su opcion:");
            int _hamchoice = Convert.ToInt32(Console.ReadLine());

           

            if ( _hamchoice == 1 ) 
            {
                Console.WriteLine("Sabia eleccion, proceda a seleccionar su preferencia de pan, carne y adicionales.");
                string carne=string.Empty;
                string pan = string.Empty;

                Console.WriteLine($"Opciones de pan:\n1)De agua\n2)Sobao");
                int panchoice = Convert.ToInt32(Console.ReadLine());

                if ( panchoice == 1)
                {
                    pan = "De Agua";
                }

                else if (panchoice == 2)
                {
                    pan = "Sobao";
                }

                Console.WriteLine($"Opciones de carne:\n1)Res\n2)Pollo");
                int carnechoice = Convert.ToInt32(Console.ReadLine());

                if (carnechoice == 1)
                {
                    carne = "Res";
                }

                else if (carnechoice == 2)
                {
                    carne = "Pollo";
                }

                Hamburguesa hamburguesa = new(pan, carne, 100);

                Console.WriteLine($"Seleccione su ingrediente adicional preferido:\n1)Lechuga\n2)Tomate\n3)Cebolla\n4)Pepinillos");
                int ingredientechoice = Convert.ToInt32(Console.ReadLine());
                string ingredichoice;

                

                hamburguesa.SeleccionarIngrediente(ingredientechoice);
                hamburguesa.CalcularCosto();

               

                Console.WriteLine($"Su tipo de pan:{ pan}, su tipo de carne{ carne}");



            }
            if (_hamchoice == 2) { }
            if (_hamchoice == 3) { }


            Console.ReadKey();





        }
    }
}