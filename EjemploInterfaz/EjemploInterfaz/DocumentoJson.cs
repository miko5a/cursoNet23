using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class DocumentoJson : IArchivosJson
    {
        public int NombreArchivo { get; set; }

        public object Deserializar(string json)
        {
            return json;
        }

        public void Escribir(string archivo)
        {
            return;
        }

        public void Leer(string archivo)
        {
            return;
        }

        public void Serializar(object json)
        {
            return;
        }
    }
}