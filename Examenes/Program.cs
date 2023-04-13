using ExamenFinalProgI;

namespace ExamenFinal
{
    public class Program
    {
        public static void Main (string[] args) 
        {

            List<Agente> agentes = new List<Agente>();
            List<Conductor> conductores = new List<Conductor>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Console.WriteLine("///Bienvenido al sistema de infracciones de transito///");
            Console.WriteLine("Por favor registre sus datos para acceder al sistema");
            Console.WriteLine("Nombre completo:");
            string nombreagente = Console.ReadLine();
            Console.WriteLine("Codigo de empleado:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Direccion:");
            string direccionagente = Console.ReadLine();
            Console.WriteLine("Fecha ingreso (mm/dd/yy):");
            DateTime fechaingreso = DateTime.Parse(Console.ReadLine());
            Console.Clear();

            Agente agente = new Agente(codigo, nombreagente, direccionagente,fechaingreso);
            agentes.Add(agente);

            if (agente != null )
            {
                
                Console.WriteLine("Registre los datos del conductor:");
                Console.WriteLine("Nombre completo:");
                string nombreconductor = Console.ReadLine();
                Console.WriteLine("Cedula:");
                int cedula = int.Parse(Console.ReadLine());   
                Console.WriteLine("Direccion:");
                string direccionconductor = Console.ReadLine();
                Console.WriteLine($"Seleccione tipo de licencia:\n1)Tipo A (Todo tipo de vehiculos)\n2)Tipo B (Vehiculos Pesados)\n3)Tipo C (Motocicletas)");
                int tipolicencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Fecha de nacimiento (mm/dd/yy:");
                DateTime fechanacimiento = DateTime.Parse(Console.ReadLine());
                Console.Clear();

                Conductor conductor = new Conductor(nombreconductor, cedula, direccionconductor, tipolicencia, fechanacimiento);
                conductores.Add(conductor);

                Console.WriteLine("Registre los datos del vehiculo:");
                Console.WriteLine("Placa:");
                string placa = Console.ReadLine();
                Console.WriteLine("Marca:");
                string marca = Console.ReadLine();
                Console.WriteLine("Modelo:");
                string modelo = Console.ReadLine(); 
                Console.WriteLine("Color:");
                string color = Console.ReadLine();  
                Console.WriteLine("Año:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Chasis:");
                string chasis = Console.ReadLine();
                Console.Clear();

                Vehiculo vehiculo = new Vehiculo(placa, marca, modelo, color, year, chasis);
                vehiculos.Add(vehiculo);

                Console.WriteLine("Digite la fecha de emision de la infraccion(mm/dd/yy):");
                DateTime fecha = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"///Seleccione el tipo de infraccion:\r\n1)Obstruccion de transito con penalidad de RD$1,800\r\n2)Pase de semaforo en rojo con penalidad de RD$5,950\r\n3)Hablar por el celular con penalidad de RD$3,750\r\n4)Conducir sin el cinturon con penalidad de RD$2,560\r\n5)Licencia vencida con penalidad de RD$3,890");
                int infraccion = int.Parse(Console.ReadLine());

                int infraccioncosto=0;
                string infracciontipo=string.Empty;

                if (infraccion == 1)
                {
                    infracciontipo = "Obstruccion de transito";
                    infraccioncosto = 1800;
                }

                else if (infraccion == 2)
                {
                    infracciontipo = "Pase de semaforo en rojo";
                    infraccioncosto = 5950;
                }

                else if (infraccion == 3)
                {
                    infracciontipo = "Hablar por el celular";
                    infraccioncosto = 3750;
                }

                else if (infraccion == 4)
                {
                    infracciontipo = "Conducir sin el cinturon";    
                    infraccioncosto = 2560;
                }

                else if (infraccion == 5)
                {
                    infracciontipo = "Licencia vencida";
                    infraccioncosto = 3890;
                }

                else
                {
                    Console.WriteLine("no ha ingresado una opcion valida.");
                }

                Infraccion infraccion1 = new Infraccion(infracciontipo, fecha, infraccioncosto);

                ;
                Console.WriteLine($"////Datos de la infraccion///\nNombre conductor: {conductor.NombreCompleto}\nCedula: {conductor.Cedula}");
                Console.WriteLine($"Tipo de infraccion: {infraccion1.Tipo}\nFecha de emision: {infraccion1.Fecha}");
                Console.WriteLine($"Nombre agente: {agente.NombreCompleto}\nCodigo de empleado: {agente.CodigoEmpleado}");
                Console.WriteLine($"Detalles del vehiculo:\nPlaca: {vehiculo.Placa}\nMarca: {vehiculo.Marca}\nModelo: {vehiculo.Modelo}\nChasis: {vehiculo.Chasis}");
                Console.WriteLine($"\nCosto: RD${infraccion1.Costo}");
            }

            else
            {
                Console.WriteLine("No ha ingresado datos validos para verificar su identidad.");
            }

            

            Console.ReadKey();
        
        
        
        
        }

       
    }
}
