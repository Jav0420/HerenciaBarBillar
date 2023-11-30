using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Inventario
    {
        // Propiedades
        public int CantPro { get; set; }
        public List<Producto> InventarioProductos { get; set; }
        // Constructor por defecto
        public Inventario()
        {
            InventarioProductos = new List<Producto>();
        }
        // Constructor con todos los parámetros
        public Inventario(int cantPro, List<Producto> inventarioProductos)
        {
            CantPro = cantPro;
            InventarioProductos = inventarioProductos;
        }
        // Ver datos
        public void VerDatos()
        {
            Console.WriteLine($"Cantidad total de productos: {CantPro}");
            Console.WriteLine("Productos en el inventario:");
        }
        // Leer datos
        public void LeerDatos()
        {
            Console.WriteLine("Ingrese la cantidad total de productos:");
            CantPro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos a ingresar:");
            int cantidadProductos = int.Parse(Console.ReadLine());
        }
    }
}
