using Extensiones;

namespace EjemploLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = "JuAN lOpEz".ConvertirCadena();

            var luis = "lUiS MaRTinEz";

            var saludo = "Hola Mundo !!!!";

            var convertir = saludo.ConvertirCadena();

            // Mostrar año de la fecha

            var fecha = DateTime.Now;
            var año = fecha.ObtenerAño();

            //Agregar metodo de extension para comparar dos enteros

            int a = 1;
            int b = 2;

            //bool esmayorAB = a > b;

            a.EsMayorQue(b);

            Console.WriteLine(saludo);
            
        }

        
    }
}