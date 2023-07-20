
using System.Runtime.InteropServices;

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Empleado juan = new Trabajador("Juan");
            //Administrador maria = new Administrador("Maria");
            //jose.Jefe = maria;

            Trabajador juan = new Trabajador("Juan");
            Administrador maria = new Administrador("Maria");
            Empleado jose = new Empleado("Jose");


            //Console.WriteLine(jose.ToString());

            var listaPersonas = new List<Empleado>();
            listaPersonas.Add(juan);
            listaPersonas.Add(maria);
            listaPersonas.Add(jose);

            foreach (var personas in listaPersonas)
            {
                Console.WriteLine(personas.ToString());
            }




        }
    }
}