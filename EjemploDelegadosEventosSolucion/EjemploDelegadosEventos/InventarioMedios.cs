using EjemploDelegadosEventos.Medios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjemploDelegadosEventos
{
    public class InventarioMedios
    {
        //Delegado para probar medios

        public delegate bool ProbarMediosDelegado();

        // Delegado para mostrar info del medio

        public delegate string InfoMedioDelegado(string id);

        public void ResultadoInfoMedioDelegado(InfoMedioDelegado infoMedioDelegado, string ID)
        {
            var resultadoPrueba = infoMedioDelegado(ID);

            Console.WriteLine(resultadoPrueba);
        }

        public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado)
        {

            // 1- Recibir el medio a probar
            // 2- Probar el medio
            // 3- Si el medio se ha podido reproducir,
            // indicar como archivarlo

            var resultadoPrueba = probarMediosDelegado();
                       
            if (resultadoPrueba)
            {
                Console.WriteLine("El medio funciona");
            }
            else
            {
                Console.WriteLine("El medio no funciona");
            }

        }
    }
}
