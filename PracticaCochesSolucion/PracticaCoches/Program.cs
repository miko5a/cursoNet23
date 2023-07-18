using Entidades;


namespace PracticaCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crear los Vehiculos
            var coche1 = new Vehiculos("1234HRH", new DateTime(2022, 01, 15), Vehiculos.Etiqueta.sinEtiqueta);

            var coche2 = new Vehiculos("5678ARS", new DateTime(2020, 04, 05), Vehiculos.Etiqueta.etiquetaB);

            var coche3 = new Vehiculos("1268FRS", new DateTime(1990, 08, 15), Vehiculos.Etiqueta.etiquetaC);

            var coche4 = new Vehiculos("3265JHI", new DateTime(1998, 06, 20), Vehiculos.Etiqueta.etiquetaCERO);

            var coche5 = new Vehiculos("4573FFM", new DateTime(2010, 03, 30), Vehiculos.Etiqueta.etiquetaECO);



            var listaCoches = new List<Vehiculos>();
            listaCoches.Add(coche1);
            listaCoches.Add(coche2);
            listaCoches.Add(coche3);
            listaCoches.Add(coche4);
            listaCoches.Add(coche5);

            foreach (var vehiculo in listaCoches)
            {
                vehiculo.CalcularImpuesto();
            }



        }
    }
}