using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class EventosEsp
    {
        //Propiedase
        public List<Cliente> VectorClientes { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        //Constructores
        public EventosEsp()
        {
            VectorClientes = new List<Cliente>();
            Nombre = "ND";
            Fecha = "ND";
        }
        public EventosEsp(List<Cliente> vectorClientes, string nom, string fech)
        {
            VectorClientes = vectorClientes;
            Nombre = nom;
            Fecha = fech;
        }
        //Funciones
        public virtual void verDatos()
        {
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine("Clientes:");
            foreach (var cliente in VectorClientes)
            {
                Console.WriteLine($"CodCliente: {cliente.CodCliente}, Correo: {cliente.Email}");
            }
        }
        public virtual void leerDatos()
        {
            Console.Write("Ingrese el nombre del evento: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese la fecha del evento (en formato yyyy-MM-dd): ");
            Fecha = Console.ReadLine();
            Console.Write("¿Cuántos clientes participarán en el evento? ");
            int numeroClientes;
            while (!int.TryParse(Console.ReadLine(), out numeroClientes) || numeroClientes < 1)
            {
                Console.Write("Por favor, ingrese un número válido mayor que cero: ");
            }
            VectorClientes.Clear();
            for (int i = 0; i < numeroClientes; i++)
            {
                Console.WriteLine($"\nDatos del Cliente {i + 1}:");
                agregarCliente();
            }
        }

        // Método para agregar un cliente
        private void agregarCliente()
        {
            var nuevoCliente = new Cliente();

            Console.Write("Ingrese el codigo cliente: ");
            nuevoCliente.CodCliente = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el Email del cliente: ");
            nuevoCliente.Email = Console.ReadLine();

            VectorClientes.Add(nuevoCliente);
        }
    }
}