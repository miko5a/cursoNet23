using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegadosEventos.Medios
{
    public class Tocadiscos
    {
        public Tocadiscos() { }

        public bool ProbarVinilo()
        {
            Console.WriteLine("Ponga el vinilo en el tocadiscos");
            Console.WriteLine("Pone el cabezal del lector en el disco");
            Console.WriteLine("Darle a reproducir");
            Console.WriteLine("Indique a continuacion si ha escuchado algo");
            var result = Console.ReadLine();

            // Equivale a if (result =="S")/else
            return result == "S";
        }

        public string ObtenerCancionesDisco(string codigoBarras)
        {
            return "Lista de canciones del [ Vinilo ] estan en la contraportada.  Su ID es: " + codigoBarras;
        }
    }
}
