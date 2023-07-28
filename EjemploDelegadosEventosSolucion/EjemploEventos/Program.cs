using System.Reflection.Metadata.Ecma335;

namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1- Crear instancia del reloj interno (Publicador)

            var reloj = new Reloj();

            // 2- Crear un reloj digital y nos suscribimos (Suscriptor)
            //var relojDigital = new RelojDigital();
            //relojDigital.Suscribir(reloj);

            //Ejercicio
            //Crear un log o registro que guarde cada 10 segundos
            //la fecha y hora
            var log = new Registro();
            log.Suscribir(reloj);

            // 3- Poner en marcha el reloj

            reloj.IniciaReloj();
        }
    }
}