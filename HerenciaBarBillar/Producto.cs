using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Producto
    {
        //PROPIEDADAES
        public string CodPro { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        //CONSTRUCTOR POR DEFECTO
        public Producto()
        {
            CodPro = "No definifo";
            Descripcion = "No definifo";
            Tipo = "No definifo";
            Nombre = "No definifo";
            Precio = 0.0;
            Stock = 0;
        }
        //CONSTRUCTOR CON TODOS LOS PARAMETROS
        public Producto(string codpro, string des, string tipo, string nom, double pre, int stock)
        {
            CodPro = codpro;
            Descripcion = des;
            Tipo = tipo;
            Nombre = nom;
            Precio = pre;
            Stock = stock;
        }
        //FUNCIONALIDAD
        public virtual void verDatos()
        {
            Console.WriteLine($"CodigoProducto: {CodPro}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"tipo: {Tipo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Stock: {Stock}");
        }
        public virtual void leerDatos()
        {
            Console.Write($"CodigoProducto:");
            CodPro = Console.ReadLine();
            Console.Write($"Descripcion:");
            Descripcion = Console.ReadLine();
            Console.Write($"Descripcion:");
            Tipo = Console.ReadLine();
            Console.Write($"Descripcion:");
            Nombre = Console.ReadLine();
            Console.Write($"Descripcion:");
            Precio = double.Parse(Console.ReadLine());
            Console.Write($"Descripcion:");
            Stock = int.Parse(Console.ReadLine());
        }
    }
}
