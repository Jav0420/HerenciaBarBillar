using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Pedido
    {
        //Propiedades
        public int CodPedido { get; set; }
        public string CodCli { get; set; }
        public string CodEmp { get; set; }
        public string Fecha { get; set; }
        public double Monto { get; set; }
        //Constructores
        public Pedido()
        {
            CodPedido = 0;
            CodCli = "No definido";
            CodEmp = "No definido";
            Fecha = "No definido";
            Monto = 0.0;
        }
        public Pedido(int codPedido, string codCli, string codEmp, string fecha, double monto)
        {
            CodPedido = codPedido;
            CodCli = codCli;
            CodEmp = codEmp;
            Fecha = fecha;
            Monto = monto;
        }
        //Funconalidad
        public void verDatos()
        {
            Console.WriteLine($"codPedido: { CodPedido}");
            Console.WriteLine($"codCliente:  { CodCli}");
            Console.WriteLine($"codEmpleado:  { CodEmp}");
            Console.WriteLine($"fecha:  { Fecha}");
            Console.WriteLine($"monto: { Monto}");
        }
        public void leerDatos()
        {
            Console.Write("codPedido: ");
            CodPedido = int.Parse(Console.ReadLine());
            Console.Write("codCliente: ");
            CodCli = Console.ReadLine();
            Console.Write("codEmpleado: ");
            CodEmp = Console.ReadLine();
            Console.Write("fecha: ");
            Fecha = Console.ReadLine();
            Console.Write("monto: ");
            Monto = double.Parse(Console.ReadLine());
        }
    }
}
