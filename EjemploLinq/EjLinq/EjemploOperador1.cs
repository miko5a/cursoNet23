using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjLinq
{
    public class EjemploOperador1
    {
        public void Ejecutar()
        {
            IEnumerable<Empleado> Empleados = new List<Empleado>()
         {
             new Empleado
             {
                 Nombre = "Jose",
                 Apellidos = "Conde",
                 Ciudad = "Madrid",
                 Telefono = "123456789",
                 Departamento = Departamento.Desarrollo
             },
             new Empleado
             {
                 Nombre = "Luis",
                 Apellidos = "Castillo",
                 Ciudad = "Madrid",
                 Telefono = "423456789",
                 Departamento = Departamento.Soporte
             },
             new Empleado
             {
                 Nombre = "Juan",
                 Apellidos = "Nuñez",
                 Ciudad = "Barcelona",
                 Telefono = "9123456789",
                 Departamento = Departamento.RH
             },
             new Empleado
             {
                 Nombre = "Maria",
                 Apellidos = "Garcia",
                 Ciudad = "Valencia",
                 Telefono = "8123456789",
                 Departamento = Departamento.Admin
             }
          };

            //Define una consulta LINQ con los empleados definidos anteriormente
            //El departamento sea desarrolo o soporte
            //El apellido empiece por C
            //Devuelve el resultado en orden descendente por nombre

            var empleadosDesarrolloSoporte = Empleados.Where(e => 
                                                                (e.Departamento == Departamento.Desarrollo ||
                                                                e.Departamento == Departamento.Soporte)
                                                                && e.Apellidos.StartsWith("C"))
                                             .OrderByDescending(e => e.Nombre)
                                             .Select(e => e.Nombre)
                                             .ToList();

            List<Empleado> empleadosDesarrolloSoporteConsulta = (from empleado in Empleados
                                                                 where (empleado.Departamento == Departamento.Desarrollo ||
                                                                   empleado.Departamento == Departamento.Soporte)
                                                                   && empleado.Apellidos.StartsWith("C")
                                                                 orderby empleado.Nombre descending
                                                                 select empleado).ToList();

            // 2- Resultados
            foreach (string e in empleadosDesarrolloSoporte)
            {
                //Console.WriteLine(e);
            }


            //Listado de los telefonos y ciudades de los empleados de Madrid
            //que contengan en su apellido una a
            //ordenado por nombre

            //var empleadosTelefonoMadrid = Empleados.Where(e =>
            //                                            e.Ciudad == "Madrid" &&
            //                                            e.Apellidos.Contains("a"))
            //                                       .OrderBy(e => e.Nombre)
            //                                       .SelectMany(e => e.Telefono, (Telefono,Ciudad) => new { Telefono, Ciudad })
            //                                       .ToList();

            var empleadosTelefonoMadrid = Empleados.Where(e =>
                                                        e.Ciudad == "Madrid" &&
                                                        e.Apellidos.Contains("a"))
                                                   .OrderBy(e => e.Nombre)
                                                   .SelectMany(e => e.Telefono)
                                                   .ToList();

            List<string> empleadosTelefonoMadridConsulta = (from empleado in Empleados
                                                              where empleado.Apellidos.Contains("a") && empleado.Ciudad == "Madrid"
                                                              orderby empleado.Nombre
                                                              select empleado.Telefono).ToList();

            var empleadosTelefonoMadridConsulta2 = (from empleado in Empleados
                                                            where empleado.Apellidos.Contains("a") && empleado.Ciudad == "Madrid"
                                                            orderby empleado.Nombre
                                                            select new
                                                            {
                                                                Telefono = empleado.Telefono,
                                                                Ciudad = empleado.Ciudad
                                                            }).ToList();

            //Agregar esta los a los antiguos empleados
            //No se permite el uso de Lista.Add
            //Se agregan todos de una vez
            var empleadosNuevos = new List<Empleado>            {                new Empleado                {                    Nombre = "Fabricio",                    Apellidos = "Cordero",                    Departamento = Departamento.Desarrollo                },                new Empleado                {                    Nombre = "Julia",                    Apellidos = "Lombardo",                    Departamento = Departamento.Admin                },            };

            //Crea una lista con los empleados Antiguos
            List<Empleado> empleadosAntiguos = Empleados
                                                .Select(e => e)
                                                .ToList();
            //Añade en la lista los empleados nuevos
            empleadosAntiguos.AddRange(empleadosNuevos);
        }
    }
}
