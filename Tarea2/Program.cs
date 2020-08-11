using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.Title="PANADERIA ALISSON";
            Panaderia ali = new Panaderia();
            ali.Producir();
            var random = new Random();
            Cliente cliente = new Cliente
            {
                Id = new Random().Next(),
                Nombre = "Alisson",
                Apellido = "chavez",
                Direccion = "Guamani",
                Preferencia = new Producto
                {
                    ProductoId = random.Next(),
                    Nombre = "Pan de Chocolate",
                    Ingredientes = "Harina,Huevos,Chocolate",
                    Calorias = 5,
                }

            };
            Empleado empleado = new Empleado
            {
                Id = new Random().Next(),
                Nombre = "Olga",
                Apellido = "Tenorio",
                Direccion = "Guamani",
                
            Funcion = new Cargo
                {
                CargoId = random.Next(),
                    Nombre = "Vendedor",
                    Descripcion = "Ayuda a los clientes con su pedido"
                }

            };
            Cliente clieA = new Cliente();
            Cliente camina = new Cliente();
            Console.WriteLine(empleado.Saludar());
            Console.WriteLine(empleado.Informacion());
            Console.WriteLine(empleado.Atender());
            Console.WriteLine(cliente.Saludar());
            Console.WriteLine(cliente.productoPreferencia());
            Console.WriteLine(ali.Producir());
            Console.WriteLine("El nuevo cliente es " + clieA.Nombre + clieA.Apellido +"con el número de teléfono " + clieA.Telefono);
            Console.WriteLine(camina.Caminar());
            Console.ReadKey();
        }
    }
}

