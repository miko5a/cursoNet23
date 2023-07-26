using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public interface IArchivosJson : IAlmacenamiento
    {

        object Deserializar(string json);

        void Serializar(object json);
    }
}