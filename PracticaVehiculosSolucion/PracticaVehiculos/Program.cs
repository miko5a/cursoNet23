using Entidades;

namespace PracticaVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear los Vehiculos
            var coche1 = new Vehiculos(new DateTime(2012, 12, 12), "Rojo");
            var coche2 = new Vehiculos(new DateTime(2002, 12, 12), "Seat", "Ibiza", "Verde");
            var coche3 = new Vehiculos("Seat", "Toledo");

            var listaCoches = new List<Vehiculos>();
            listaCoches.Add(coche1);
            listaCoches.Add(coche2);
            listaCoches.Add(coche3);

            foreach (var vehiculo in listaCoches)
            {
                vehiculo.MostrarVehiculo();
            }

        }
    }
}