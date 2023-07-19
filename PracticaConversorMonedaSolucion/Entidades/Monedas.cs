
namespace Entidades
{
    public class Monedas
    {
        public static double CalculoConversor(double cantidadMoneda, string moneda1, string moneda2)
        {
            double resultado = 0;

            if (moneda1 == "EUR")
            {
                switch (moneda2)
                {
                    case "LIBRA":
                        resultado = cantidadMoneda * 0.86;
                        break;
                    case "DOLAR":
                        resultado = cantidadMoneda * 1.12;
                        break;
                }
            }
            else if (moneda1 == "LIBRA")
            {
                switch (moneda2)
                {
                    case "EURO":
                        resultado = cantidadMoneda / 0.86;
                        break;
                    case "DOLAR":
                        resultado = cantidadMoneda * 1.29;
                        break;
                }
            }
            else if (moneda1 == "DOLAR")
            {
                switch (moneda2)
                {
                    case "LIBRA":
                        resultado = cantidadMoneda / 1.29;
                        break;
                    case "EURO":
                        resultado = cantidadMoneda / 1.12;
                        break;
                }
            }

            return resultado;
            //throw new NotImplementedException();
        }

    }
}
