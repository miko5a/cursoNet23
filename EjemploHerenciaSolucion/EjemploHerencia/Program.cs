
using System.Runtime.InteropServices;

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trabajador juan = new Trabajador("Juan", "Tarde");
            Administrador maria = new Administrador("Maria",false);
            Empleado jose = new Empleado("Jose");

            ExternoOut paco = new ExternoOut("Paco", "Acciona");

            Trabajador pedro = new Trabajador("Pedro", "Mañana");
            Trabajador miguel = new Trabajador("Miguel", true, "Acciona");
            Administrador javier = new Administrador("Javier", true, 15);
            Administrador pepe = new Administrador("Pepe");

            juan.Jefe = maria;
            pedro.Jefe = maria;


            var listaPersonas = new List<Empleado>();
            listaPersonas.Add(juan);
            listaPersonas.Add(maria);
            listaPersonas.Add(jose);
            listaPersonas.Add(paco);

            listaPersonas.Add(pedro);
            listaPersonas.Add(miguel);
            listaPersonas.Add(javier);
            listaPersonas.Add(pepe);

            var listaPersonas2 = new List<Empleado>();
            listaPersonas2.Add(juan);
            listaPersonas2.Add(maria);
            listaPersonas2.Add(jose);

            //Mostrar Empleados

            foreach (var personas in listaPersonas)
            {
                var tipo = personas.GetType().Name;
                //Console.WriteLine(tipo);

                switch (tipo)
                {
                    case "Trabajador":
                        //TODO: Mostrar Turno
                        var trabajador = (Trabajador)personas;
                        Console.WriteLine(trabajador.ConsultaTurno());
                        break;
                    case "Administrador":
                        //TODO:Si tiene plaza, mostrar plaza parking
                        var administrador = (Administrador)personas;
                        Console.WriteLine(administrador.ConsultaPlazaParking());
                        break;
                    case "ExternoOut":
                        //TODO:Mostrar nombre de empresa
                        var externo = (ExternoOut)personas;
                        Console.WriteLine(externo.ConsultaEmpresaExterna());
                        break;
                    default:
                        break;
                }
            }

            // Mostrar Empelados que empiezan con la letra "J"
            var resultado = from emp in listaPersonas
                            where emp.Nombre.ToLower().StartsWith("j")
                            orderby emp.Nombre ascending 
                            select emp;


            var resultado2 = from emp in listaPersonas
                             join esx in listaPersonas2
                             on emp.Nombre equals esx.Nombre
                             select emp;
            //foreach (var item in resultado2)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            // Excepcion personalizada a la hora de pedir el parking a un administrativo
            //try
            //{
            //    if (javier.PlazaParking)
            //    {
            //        Console.WriteLine(javier.ConsultaPlazaParking());
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }
    }
}