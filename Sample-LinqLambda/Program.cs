using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sample_LinqLambda
{
    class Program
    {
        public static List<Empleado> Empleados = new List<Empleado>
            {
                new Empleado{Id = 100, FechaIngreso = new DateTime(2000,1,14), Nombre = "Roberto", Puesto = "Desarrollo", Sueldo = 15000},
                new Empleado{Id = 101, FechaIngreso = new DateTime(2010,10,12), Nombre = "Juan Carlos", Puesto = "Desarrollo", Sueldo = 12000},
                new Empleado{Id = 102, FechaIngreso = new DateTime(2013,8,8), Nombre = "Martha", Puesto = "Contabilidad", Sueldo = 10000},
                new Empleado{Id = 103, FechaIngreso = new DateTime(2000,9,4), Nombre = "Miguel", Puesto = "Contabilidad", Sueldo = 8000},
                new Empleado{Id = 104, FechaIngreso = new DateTime(2000,3,16), Nombre = "Roberto", Puesto = "Finanzas", Sueldo = 9000},
                new Empleado{Id = 105, FechaIngreso = new DateTime(2013,5,5), Nombre = "Lourdes", Puesto = "Gerencia", Sueldo = 25000}
            };

        private static void Filtro()
        {
            var empsL = Empleados.Where(e => e.Sueldo > 10000);
            var empsQ = from e in Empleados
                        where e.Sueldo > 10000
                        select e;

        }

        private static void FiltroDosAtributos()
        {
            var empsL = Empleados.Where(e => e.Sueldo > 10000 && e.Puesto.Equals("Desarrollo"));
            var empsQ = from e in Empleados
                        where e.Sueldo > 10000 && e.Puesto.Equals("Desarrollo")
                        select e;

        }

        private static void OrdenamientoAscendente()
        {
            var empsL = Empleados.OrderBy(e => e.FechaIngreso);
            var empsQ = from e in Empleados
                        orderby e.FechaIngreso
                        select e;

        }

        private static void OrdenamientoDescendente()
        {
            var empsL = Empleados.OrderByDescending(e => e.FechaIngreso);
            var empsQ = from e in Empleados
                        orderby e.FechaIngreso descending
                        select e;

        }
        static void Main(string[] args)
        {

        }
    }
}
