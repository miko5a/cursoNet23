using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegadosEventos.Medios
{
    public class ReproductorCds
    {

        public bool ProbarCd()
        {
            Console.WriteLine("Ponga el Cd en el reproductor");
            Console.WriteLine("Pulsa el boton de reproducción");
            Console.WriteLine("Indique a continuacion si ha escuchado algo");
            var result = Console.ReadLine();

            // Equivale a if (result =="S")/else
            return result == "S";
        }

        public string ObtenerCancionesCDs(string codigoBarras)
        {
            return "Lista de canciones del [ CD ] estan en la portada.  Su ID es: " + codigoBarras;
        }
    }
}
