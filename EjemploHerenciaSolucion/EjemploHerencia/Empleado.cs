using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public partial class Empleado
    {
        public string Nombre {get;set;}

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public Empleado(string nombre, Empleado jefe)
        {
            Nombre = nombre;
            Jefe = jefe;
        }

        protected double diasVacaciones;

        public virtual void CalculoVacaciones()
        {
            diasVacaciones += 10;
        }

        public override string ToString()
        {
            CalculoVacaciones();
            return $" Empleado. Nombre: [ {Nombre} ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
        }
    }
}