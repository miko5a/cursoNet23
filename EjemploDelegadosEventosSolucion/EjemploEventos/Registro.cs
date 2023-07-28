using System.Security.Cryptography.X509Certificates;

namespace EjemploEventos
{
    internal class Registro
    {
        private int segundo = 0;

        DateTime date1 = DateTime.Now;
        DateTime date2 = DateTime.Now;

        public Registro()
        {
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            ///////////////// CONTADOR /////////////////////
            //if (segundo >= 10)
            //{
            //    //Guardar Info Tiempo
            //    Console.WriteLine($"Fech Actual: {DateTime.Now}" +
            //                   $" Hora Actual: {e.Hora.ToString()}" +
            //                   $":{e.Minuto.ToString()}" +
            //                   $" {e.Segundo.ToString()}");
            //    segundo = 0;
            //}
            //segundo++;

            ///////////////// TIMESPAN /////////////////////
            date1 = DateTime.Now;
            TimeSpan intervalo = date1 - date2;

            if (intervalo.Seconds >= 10)
            {
                //Guardar Info Tiempo
                Console.WriteLine($"Fech Actual: {DateTime.Now}" +
                               $" Hora Actual: {e.Hora.ToString()}" +
                               $":{e.Minuto.ToString()}" +
                               $" {e.Segundo.ToString()}");
                date2 = DateTime.Now;
            }
        }
    }
}