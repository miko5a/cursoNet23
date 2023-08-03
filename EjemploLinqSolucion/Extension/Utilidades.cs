using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Utilidades
    {

        public static string ConvertirCadena(this string cadena)
        {
            return cadena.Trim().ToUpper() + ".";
        }
    }
}
