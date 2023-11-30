using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Bebidas : Producto
    {
        //PROPIEDADAES
        public int Cantidad { get; set; }
        //CONSTRUCTOR POR DEFECTO
        public Bebidas() : base()
        {
            Cantidad = 0;
        }
        //CONSTRUCTOR CON TODOS LOS PARAMETROS
        public Bebidas(int cant, string codpro, string des, string tipo, string nom, double pre, int stock) : base(codpro, des, tipo, nom, pre, stock)
        {
            Cantidad = cant;
        }
        //FUNCIONALIDAD
        public override void verDatos()
        {
            Console.WriteLine($"Cantidad: {Cantidad}");
        }
        public override void leerDatos()
        {
            Console.Write($"Cantidad:");
            Cantidad = int.Parse(Console.ReadLine());
        }
    }
}
