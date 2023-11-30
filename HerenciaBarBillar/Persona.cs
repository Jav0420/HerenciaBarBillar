using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    abstract class Persona
    {
        //Propiedades
        public int Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //Constructores 
        public Persona()
        {
            Ci = 0;
            Nombre = "No Definido";
            Apellido = "No Definido";
        }
        public Persona(int ci, string nombre, string apellido)
        {
            Ci = ci;
            Nombre = nombre;
            Apellido = apellido;
        }
        //Funcionalidad
        public virtual void verDatos()
        {
            Console.WriteLine($"Ci : {Ci}");
            Console.WriteLine($"Nombre : {Nombre}");
            Console.WriteLine($"Apellido : {Apellido}");
        }
        public virtual void leerDatos()
        {
            Console.Write($"Ci : ");
            Ci = int.Parse(Console.ReadLine());
            Console.Write($"Nombre : {Nombre}");
            Nombre = Console.ReadLine();
            Console.Write($"Apellido : {Apellido}");
            Apellido = Console.ReadLine();
        }
    }
}
