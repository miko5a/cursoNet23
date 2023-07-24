using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public interface IArchivosJson : IArchivo
    {
        object Deserializar(string json);

        void Serializar(object json);
    }
}