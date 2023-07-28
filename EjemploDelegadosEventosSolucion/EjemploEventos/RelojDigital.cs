namespace EjemploEventos
{
    public class RelojDigital
    {
        public RelojDigital()
        {
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
                Console.WriteLine($"Hora Actual: {e.Hora.ToString()}" +
                               $":{e.Minuto.ToString()}" +
                               $" {e.Segundo.ToString()}");
        }
    }
}