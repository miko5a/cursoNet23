using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Empleado
    {
        public virtual string Nombre { get; set; }

        protected double diasVacaciones;

        public Empleado()
        {
            
        }
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void CalculoVacaciones()
        {
            diasVacaciones += 10;
           
        }

        public virtual void CalculoNomina() { }

        public override string ToString()
        {
            return $"[ Empleado. Nombre: {Nombre} Dias Vacaciones: {diasVacaciones} ";
        }
    }
}
