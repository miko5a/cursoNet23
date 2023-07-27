using EjemploDelegadosEventos.Medios;
using static EjemploDelegadosEventos.InventarioMedios;

namespace EjemploDelegadosEventos
{
    internal class Program
    {

        // Hay que crear una aplicacion para el archivo
        // de medios de una biblioteca publico de modo que;
        //
        // A- Segun el tipo de medio indique al usuario los pasos
        // a dar para reproducir ese medio y verificar si esta en
        // buen estado para archivarlo o bien desecharlo si esta
        // en mal estado
        //
        // B- Crear una aplicacion que permita
        // indicar los pasos a dar independientemente del medio

        // C- Mostrar el contenido del medio segun el tipo de medio
        //  Pasar codigo de barras o identificador para localizar
        //  el medio en la BBDD
        //  CD- Mostrar lista canciones
        //  Vinilo - Mostrar lista canciones en la contraportada
        //  VHS - Mostrar informacion de la pelicula
        static void Main(string[] args)
        {
            // 1 - Crear Instancias
            var inventarioMedios = new InventarioMedios();

            var reproductorCassete = new RadioCasete();
            var reproductorCDs = new ReproductorCds();
            var tocaDiscos = new Tocadiscos();

            // 2 - Crear instancias de delegados

            ProbarMediosDelegado probarDiscosDelegado = new ProbarMediosDelegado(tocaDiscos.ProbarVinilo);
            ProbarMediosDelegado probarCdsDelegado = new ProbarMediosDelegado(reproductorCDs.ProbarCd);



            InfoMedioDelegado infoDiscosDelegado = new InfoMedioDelegado(tocaDiscos.ObtenerCancionesDisco);
            InfoMedioDelegado infoCDsDelegado = new InfoMedioDelegado(reproductorCDs.ObtenerCancionesCDs);
            InfoMedioDelegado infoRadioCasete = new InfoMedioDelegado(reproductorCassete.ObtenerCancionesCassete);



            // 3 - Utilizar Delegados

            // Probar un vinilo
            //inventarioMedios.ResultadoProbarMedios(probarDiscosDelegado);
            // Probar un CD
            //inventarioMedios.ResultadoProbarMedios(probarCdsDelegado);


            // Informacion de Medios introduciendo codigo barras
            inventarioMedios.ResultadoInfoMedioDelegado(infoDiscosDelegado,"1234");
            inventarioMedios.ResultadoInfoMedioDelegado(infoCDsDelegado,"5678");
            inventarioMedios.ResultadoInfoMedioDelegado(infoRadioCasete, "1111");




            
        }
    }
}