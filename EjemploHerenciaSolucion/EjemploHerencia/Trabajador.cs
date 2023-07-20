using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre) : base(nombre)
        {
        }

        public override string ToString()
        {
            return $"[ Trabajador. Nombre: {Nombre} " +
                $" Dias Vacaciones: {diasVacaciones}";
        }
    }
}