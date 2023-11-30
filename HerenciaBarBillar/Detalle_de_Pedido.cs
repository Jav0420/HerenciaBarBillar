using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Detalle_de_Pedido
    {
        //Propiedades
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        //Constructores
        public Detalle_de_Pedido()
        {
            Cantidad = 0;
            Precio = 0.0;
        }
        public Detalle_de_Pedido(string prod, int cantidad, double precio)
        {
            Cantidad = cantidad;
            Precio = precio;
        }
        //Funconalidad
        public void verDatos()
        {
            Console.WriteLine($"Cantidad:  { Cantidad}");
            Console.WriteLine($"Precio:  { Precio}");
        }
        public void leerDatos()
        {
            Console.Write("Cantidad: ");
            Cantidad = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            Precio = double.Parse(Console.ReadLine());
        }
    }
}
