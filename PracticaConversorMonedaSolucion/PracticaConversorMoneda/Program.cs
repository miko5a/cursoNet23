using Entidades;

namespace PracticaConversorMoneda
{
    internal class Program
    {
        private static double cont;

        static void Main(string[] args)
        {
            string seleccion = String.Empty;
            string seleccionCambio = String.Empty;
            string moneda1;
            string moneda2;

            while (seleccion != "q" && seleccion != "Q")
            {
                Console.WriteLine(" ");
                Console.WriteLine("=== Introduce moneda a convertir ===");
                Console.WriteLine("===        (E) Euros             ===");
                Console.WriteLine("===        (L) Libra             ===");
                Console.WriteLine("===        (D) Dolar             ===");
                Console.WriteLine("(Q) Salir");

                seleccion = Console.ReadLine();
                double cantidadMoneda = 0;
                double resultado = 0;

                switch (seleccion)
                {
                    case "E":
                    case "e":
                        cantidadMoneda = IngresarEntero();
                        moneda1 = "EUR";
                        Console.WriteLine("=== En que moneda deseas convertir ===");
                        Console.WriteLine("===         (L) Libra              ===");
                        Console.WriteLine("===         (D) Dolar              ===");
                        seleccionCambio = Console.ReadLine();
                        switch (seleccionCambio)
                        {
                            case "L":
                            case "l":
                                moneda2 = "LIBRA";
                                resultado = Monedas.CalculoConversor(cantidadMoneda, moneda1, moneda2);
                                Console.WriteLine($"El valor al cambio es: (((( {resultado:f2} ))))");
                                break;
                            case "D":
                            case "d":
                                moneda2 = "DOLAR";
                                resultado = Monedas.CalculoConversor(cantidadMoneda, moneda1, moneda2);
                                Console.WriteLine($"El valor al cambio es: (((( {resultado:f2} ))))");
                                break;
                        }
                        break;

                    case "L":
                    case "l":
                        cantidadMoneda = IngresarEntero();
                        moneda1 = "LIBRA";
                        Console.WriteLine("=== En que moneda deseas convertir ===");
                        Console.WriteLine("===         (E) Euro              ===");
                        Console.WriteLine("===         (D) Dolar              ===");
                        seleccionCambio = Console.ReadLine();
                        switch (seleccionCambio)
                        {
                            case "E":
                            case "e":
                                moneda2 = "EURO";
                                resultado = Monedas.CalculoConversor(cantidadMoneda, moneda1, moneda2);
                                Console.WriteLine($"El valor al cambio es: (((( {resultado:f2} ))))");
                                break;
                            case "D":
                            case "d":
                                moneda2 = "DOLAR";
                                resultado = Monedas.CalculoConversor(cantidadMoneda, moneda1, moneda2);
                                Console.WriteLine($"El valor al cambio es: (((( {resultado:f2} ))))");
                                break;
                        }
                        break;
                    case "D":
                    case "d":
                        cantidadMoneda = IngresarEntero();                        
                        moneda1 = "DOLAR";
                        Console.WriteLine("=== En que moneda deseas convertir ===");
                        Console.WriteLine("===         (L) Libra              ===");
                        Console.WriteLine("===         (D) Dolar              ===");
                        seleccionCambio = Console.ReadLine();
                        switch (seleccionCambio)
                        {
                            case "E":
                            case "e":
                                moneda2 = "EURO";
                                resultado = Monedas.CalculoConversor(cantidadMoneda, moneda1, moneda2);
                                Console.WriteLine($"El valor al cambio es: (((( {resultado:f2} ))))");
                                break;
                            case "L":
                            case "l":
                                moneda2 = "LIBRA";
                                resultado = Monedas.CalculoConversor(cantidadMoneda, moneda1, moneda2);
                                Console.WriteLine($"El valor al cambio es: (((( {resultado:f2} ))))");
                                break;
                        }
                        break;

                    case "q":
                    case "Q":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Prueba de nuevo.");
                        break;
                }
            }
        }

        private static int IngresarEntero()
        {
            int valor;
            Console.Write("Introduce la cantidad: ");
            while (!Int32.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("El dato ingresado no es un entero");
                Console.Write("Introduce la cantidad: ");
            }

            return valor;
        }
    }
}