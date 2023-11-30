using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Gerente:Persona, ITrabajador
    {
        //propiedades
        public string CodGe { get; set; }
        public List<Empleado> empleadosCon = new List<Empleado>();
        //Aplicacion de interfaz
        public double Salario { get; set; }
        public int HorasDeTrabajo { get; set; }
        //Constructores
        public Gerente() : base()
        {
            CodGe = "No Definido";
            Salario = 0.0;
            HorasDeTrabajo = 0;
        }
        public Gerente(double salario,int horasDeTrabajo, string codEmpleado, int ci, string nombre, string apellido) : base(ci, nombre, apellido)
        {
            CodGe = codEmpleado;
            Salario = salario;
            HorasDeTrabajo = horasDeTrabajo;
        }
        //funcionalidad
        public override void verDatos()
        {
            base.verDatos();
            Console.WriteLine("Datos del gerente: ");
            Console.WriteLine($"Codigo de empleado: {CodGe}");
            Console.WriteLine("Datos de los empleados contratados: ");
            foreach (Empleado empleado in empleadosCon)
            {
                Console.WriteLine($"Codigo de empleado: {empleado.CodEmp}");
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Apellido: {empleado.Apellido}");
                Console.WriteLine($"Cargo: {empleado.Cargo}");
                Console.WriteLine();
            }
        }
        public override void leerDatos()
        {
            base.leerDatos();
            Console.WriteLine("Ingrese los datos del gerente: ");
            CodGe = Console.ReadLine();
        }
    }
}
