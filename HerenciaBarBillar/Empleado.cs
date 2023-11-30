using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaBarBillar
{
    class Empleado:Persona, ITrabajador
    {
        //propiedades
        public int CodEmp { get; set; }
        public string Cargo { get; set; }
        //interfaz
        public double Salario { get; set; }
        public int HorasDeTrabajo { get; set; }
        //Constructores
        public Empleado() : base()
        {
            CodEmp = 0;
            Cargo = "no definido";
            Salario = 0.0;
            HorasDeTrabajo = 0;
        }
        public Empleado(double salario, int horasDeTrabajo, int codE, string car ,int ci, string nombre, string apellido) : base(ci,nombre,apellido)
        {
            CodEmp = codE;
            Cargo = car;
            Salario = salario;
            HorasDeTrabajo = horasDeTrabajo;
        }
        //funcionalidad
        public override void verDatos()
        {
            base.verDatos();
            Console.WriteLine($"codigo de empleado: {CodEmp}");
            Console.WriteLine($"cargo de empleado: {Cargo}");
        }
        public override void leerDatos()
        {
            base.verDatos();
            Console.Write("codigo de empleado: ");
            CodEmp = int.Parse(Console.ReadLine());
            Console.Write("cargo de empleado: ");
            Cargo = Console.ReadLine();
        }
    }
}
