using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Articulos : Producto
    {
        //PROPIEDADAES
        public double Tamaño { get; set; }
        //CONSTRUCTOR POR DEFECTO
        public Articulos() : base()
        {
            Tamaño = 0.0;
        }
        //CONSTRUCTOR CON TODOS LOS PARAMETROS
        public Articulos(double tam, string codpro, string des, string tipo, string nom, double pre, int stock) : base(codpro, des, tipo, nom, pre, stock)
        {
            Tamaño = tam;
        }
        //FUNCIONALIDAD
        public override void verDatos()
        {
            Console.WriteLine($"Cantidad: {Tamaño}");
        }
        public override void leerDatos()
        {
            Console.Write($"Cantidad:");
            Tamaño = int.Parse(Console.ReadLine());
        }
    }
}
