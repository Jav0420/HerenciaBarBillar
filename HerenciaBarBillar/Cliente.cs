using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Cliente:Persona
    {
        //propiedades
        public int CodCliente { get; set; }
        public string Email { get; set; }
        //constructor por defecto
        public Cliente()
        {
            CodCliente = 0;
            Email = "No Definido";
        }
        //constructor con todos los parametros
        public Cliente(int codcli, string email)
        {
            CodCliente = codcli;
            Email = email;
        }
        //funcionalidad
        //ver datos
        public override void verDatos()
        {
            Console.WriteLine($"Codigo de cliente:{CodCliente}");
            Console.WriteLine($"Email:{Email}");
        }
        //leerdatos
        public override void leerDatos()
        {
            Console.Write("Codigo de cliente:");
            CodCliente = int.Parse(Console.ReadLine());
            Console.Write("Email:");
            Email = Console.ReadLine();
        }
    }
}
