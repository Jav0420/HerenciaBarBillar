using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Mesa
    {
        //Propiedades
        public int NroMesa { get; set; }
        public int PrecioHora { get; set; }
        public bool Accesorios { get; set; }//
        //constructor por defecto
        public Mesa()
        {
            NroMesa = 0;
            PrecioHora = 0;
        }
        //constructor con todos los parametros
        public Mesa(int nroMesa, int precioHora)
        {
            NroMesa = nroMesa;
            PrecioHora = precioHora;
        }
        //funcionalidad ver y leer Datos
        public void verDatos()
        {
            Console.WriteLine($"codPedido: { NroMesa}");
            Console.WriteLine($"codCliente:  { PrecioHora}");
            Console.WriteLine($"codEmpleado:  { Accesorios}");
        }
        public void leerDatos()
        {
            Console.Write("codPedido: ");
            NroMesa = int.Parse(Console.ReadLine());
            Console.Write("codCliente: ");
            PrecioHora = int.Parse(Console.ReadLine());
        }
    }
}
