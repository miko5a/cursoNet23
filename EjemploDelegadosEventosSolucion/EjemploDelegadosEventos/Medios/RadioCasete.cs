using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegadosEventos.Medios
{
    public class RadioCasete
    {
        public bool ProbarRadioCasete()
        {
            Console.WriteLine("Ponga el Casaete en el RadioCasete");
            Console.WriteLine("Pulsa el boton de reproducción");
            Console.WriteLine("Indique a continuacion si ha escuchado algo");
            var result = Console.ReadLine();

            // Equivale a if (result =="S")/else
            return result == "S";
        }

        public string ObtenerCancionesCassete(string codigoBarras)
        {
            return "Lista de canciones del [ CASSETE ] estan en la portada del Cassete.  Su ID es: " + codigoBarras;
        }
    }
}
