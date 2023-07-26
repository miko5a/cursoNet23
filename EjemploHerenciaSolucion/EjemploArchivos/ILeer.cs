using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public interface ILeer
    {

        public double Duracion { get; set; }

        void LeerEnVozAlta();
    }
}