using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre) : base(nombre)
        {
        }
        public Administrador(string nombre, bool plazaParking, int numeroPlaza) : base(nombre)
        {
            PlazaParking = plazaParking;
            NumeroPlaza = numeroPlaza;
        }

        public Administrador(string nombre, bool plazaParking) : base(nombre)
        {
            PlazaParking = plazaParking;
        }

        public bool PlazaParking { get; set; }
        public int NumeroPlaza { get; set; }

        public override string ToString()
        {
            if (PlazaParking == true)
            {
                return $" Administrador. Nombre: [ {Nombre} ] " +
                $" con plaza de aparcamiento [ {NumeroPlaza} ]";
            }

            return $" Administrador. Nombre: [ {Nombre} ] ";
        }
    }
}