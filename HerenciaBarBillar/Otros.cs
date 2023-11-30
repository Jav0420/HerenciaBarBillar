using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Otros : EventosEsp
    {
        //Propiedades
        public string Tipo { get; set; }
        //Constructores
        public Otros() : base()
        {
            Tipo = "ND";
        }
        public Otros(List<Cliente> vectorClientes, string nom, string fech, string tipo)
            : base(vectorClientes, nom, fech)
        {
            Tipo = tipo;
        }
        //funcionalidad
        public override void verDatos()
        {
            base.verDatos();
            Console.WriteLine($"Tipo: {Tipo}");
        }
        public override void leerDatos()
        {
            base.leerDatos();
            Console.Write("Ingrese el tipo de evento: ");
            Tipo = Console.ReadLine();
        }
    }
}

