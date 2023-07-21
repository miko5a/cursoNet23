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

        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;
        }

        public string ConsultaPlazaParking()
        {
            return new ErrorBaseDeDatosExcepcion("[Fallo en la consulta de la plaza de parking]", DateTime.Now).errorString();

            //return PlazaParking ? NumeroPlaza : "No tiene plaza";
            
        }

        public override string ToString()
        {
            CalculoVacaciones();
            if (PlazaParking == true)
            {
                return $" Administrador. Nombre: [ {Nombre} ] " +
                $" con plaza de aparcamiento [ {NumeroPlaza} ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
            }

            return $" Administrador. Nombre: [ {Nombre} ] ]" +
                $" días de vacaciones: [ {diasVacaciones} ]";
        }
    }
}