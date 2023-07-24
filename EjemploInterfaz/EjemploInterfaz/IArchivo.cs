using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public interface IArchivo
    {
        int NombreArchivo { get; set; }

        void Leer(string archivo);
        void Escribir(string archivo);
    }
}