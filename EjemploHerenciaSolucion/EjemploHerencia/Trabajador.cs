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
        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }
        public override string ToString()
        {
            CalculoVacaciones();
            if (Externo == true)
            {
                return $" Trabajador. Nombre: [ {Nombre} ]  " +
                $" de la Empresa [ {Empresa} ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
            }
            if (Jefe != null)
            {
                if (Turno != null)
                {
                    return $" Trabajador. Nombre: [ {Nombre} ]" +
                    $" trabaja de turno [ {Turno} ]  y su jefe es [ {Jefe.Nombre} ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
                }
                return $" Trabajador. Nombre: [ {Nombre} ]  " +
                    $" trabaja de turno [ {Turno} ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
            }

            return $" Trabajador. Nombre: [ {Nombre} ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
        }
    }
}