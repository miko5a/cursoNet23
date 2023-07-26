using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Modelo
{
    public class DocumentoJson : IArchivosJson
    {
        public int NombreArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Deserializar(string json)
        {
            throw new NotImplementedException();
        }

        public void Escribir(string archivo)
        {
            throw new NotImplementedException();
        }

        public void Leer(string archivo)
        {
            throw new NotImplementedException();
        }

        public void Serializar(object json)
        {
            var empleado = new Empleado("nombre");

            //JsonSerializer serializer = new JsonSerializer();
            //   using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
            //   {
            //       using (JsonWriter writer = new JsonTextWriter(sw))
            //       {
            //           serializer.Serialize(writer, json);

            //       }

            // {
            //    Nombre: "juan"
            // }
        }
            
        }
    }
}