using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public class ErrorBaseDeDatosExcepcion : Exception
    {
        public string Mensaje { get; set; }
        public DateTime FechaHoraExcepcion { get; set; }

        public ErrorBaseDeDatosExcepcion(string mensaje, DateTime fechaHoraExcepcion) :base(mensaje)
        {
            Mensaje = mensaje;
            FechaHoraExcepcion = fechaHoraExcepcion;
        }

        public string errorString()
        {
            return $" (Error) a la hora: {FechaHoraExcepcion} con mensaje: {Mensaje}";
        }
    }
}
