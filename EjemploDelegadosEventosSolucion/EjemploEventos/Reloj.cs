using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public class Reloj
    {
        public DateTime fechaHoraActual;
        public int segundo;

        //Delegado
        public delegate void CambioSegundoDelegado(object reloj,
            InformacionTiempoEventArgs informacionTiempo);

        //Evento

        public event CambioSegundoDelegado CambioSegundoEvento;


        public Reloj() { }

        public void IniciaReloj()
        {
            for(; ; )
            {
                Thread.Sleep(100);

                fechaHoraActual = DateTime.Now;

                if (fechaHoraActual.Second != segundo)
                {
                    Console.WriteLine(segundo);
                    //Guardar Info Tiempo
                    var informacionTiempo = new InformacionTiempoEventArgs(
                        fechaHoraActual.Hour,
                        fechaHoraActual.Minute,
                        fechaHoraActual.Second);

                    //Lanza el evento
                    if (CambioSegundoEvento != null)
                    {
                        CambioSegundoEvento(this, informacionTiempo);
                    }

                }
                segundo = fechaHoraActual.Second;
            }
        }
    }
}
