namespace Entidades
{
    public class Vehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime AñoCompra { get; set; }


        public Vehiculos(DateTime añoCompra, string color)
        {
            AñoCompra = añoCompra;
            Color = color;
        }
        public Vehiculos(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public Vehiculos(DateTime añoCompra, string marca, string modelo, string color)
        {
            AñoCompra = añoCompra;
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }

        public void MostrarVehiculo()
        {
            Console.WriteLine($"=========   Vehículo   =========");
            if (AñoCompra.Year != 1) { 
                Console.WriteLine($"Año Compra: {AñoCompra.Year}");
            }
            if (Marca != null){
                Console.WriteLine($"Marca: {Marca}");
            }
            if (Modelo != null)
            {
                Console.WriteLine($"Modelo: {Modelo}");
            }
            if (Color != null)
            {
                Console.WriteLine($"Color: {Color}");
            }
        }
    }
}
