using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Documento : IAlmacenamiento, ILeer
    {
        public double Duracion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NombreArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Escribir(string archivo)
        {
            throw new NotImplementedException();
        }

        public void Leer(string archivo)
        {
            throw new NotImplementedException();
        }

        public void LeerEnVozAlta()
        {
            throw new NotImplementedException();
        }
    }
}