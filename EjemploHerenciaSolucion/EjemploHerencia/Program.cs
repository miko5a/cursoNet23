
using System.Runtime.InteropServices;

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trabajador juan = new Trabajador("Juan", "Tarde");
            Administrador maria = new Administrador("Maria");
            Empleado jose = new Empleado("Jose");

            Trabajador pedro = new Trabajador("Pedro", "Mañana");
            Trabajador miguel = new Trabajador("Miguel", true, "Acciona");
            Administrador javier = new Administrador("Javier", true, 15);
            Administrador pepe = new Administrador("Pepe", false);

            juan.Jefe = maria;
            pedro.Jefe = maria;


            var listaPersonas = new List<Empleado>();
            listaPersonas.Add(juan);
            listaPersonas.Add(maria);
            listaPersonas.Add(jose);

            listaPersonas.Add(pedro);
            listaPersonas.Add(miguel);
            listaPersonas.Add(javier);
            listaPersonas.Add(pepe);

            //foreach (var personas in listaPersonas)
            //{
            //    Console.WriteLine(personas.ToString());
            //}

            foreach (var personas in listaPersonas)
            {
                var nombreMinuscula = personas.Nombre.ToLower();
                if (nombreMinuscula.StartsWith("j"))
                {
                    Console.WriteLine(personas.ToString());
                }
            }




        }
    }
}