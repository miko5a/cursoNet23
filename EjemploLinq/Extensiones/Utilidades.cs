﻿namespace Extensiones
{
    public static class Utilidades
    {

        public static string ConvertirCadena(this string cadena)
        {
            return cadena.Trim().ToUpper() + ".";
        }


        public static int ObtenerAño(this DateTime dateTime)
        {
            return dateTime.Year;
        }


        public static bool EsMayorQue(this int numero1, int numero2)
        {
            return numero1 > numero2;
        }

        public static int Primero(this List<int> lista)
        {
            return lista.FirstOrDefault(x => x > 0);
        }
    }
}