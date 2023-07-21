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
        public Trabajador(string nombre, string turno) : base(nombre)
        {
            Turno = turno;
        }

        public Trabajador(string nombre, bool externo, string empresa) : base(nombre)
        {
            Externo = externo;
            Empresa = empresa;
        }

        public string Turno { get; set; }
        public bool Externo { get; set; }
        public string Empresa { get; set; }

        public override string ToString()
        {
            if (Externo == true)
            {
                return $" Trabajador. Nombre: [ {Nombre} ]  " +
                $" de la Empresa [ {Empresa} ] ";
            }
            if (Jefe != null)
            {
                if (Turno != null)
                {
                    return $" Trabajador. Nombre: [ {Nombre} ]" +
                    $" trabaja de turno [ {Turno} ]  y su jefe es [{Jefe.Nombre} ] ";
                }
                return $" Trabajador. Nombre: [ {Nombre} ]  " +
                    $" trabaja de turno [ {Turno} ] ";
            }
            
            return $" Trabajador. Nombre: [ {Nombre} ]  ";
        }
    }
}