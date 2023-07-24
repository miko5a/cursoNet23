using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public class ExternoOut : Empleado
    {
        public string Empresa { get; set; }

        public ExternoOut(string nombre) : base(nombre)
        {
        }
        public ExternoOut(string nombre, string empresa) : base(nombre)
        {
            Empresa = empresa;
        }

        public string ConsultaEmpresaExterna()
        {
            //return new ErrorBaseDeDatosExcepcion("[Fallo en la consulta de la plaza de parking]", DateTime.Now).errorString();

            return $" Externo. Nombre: [ {Nombre} ]" +
                $" trabaja en la empresa [ {Empresa} ]";

        }
    }
}
