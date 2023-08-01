namespace EjLinq
{
    public class EjemploBasico
    {
        public EjemploBasico()
        {
        }

        public void Ejecutar()
        {
            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            // Selecciona todos los niveles cuya longitud en caracteres
            // sea mayor que 6
            // ordenado por nivel
            var listaConsulta = new List<string>();
            foreach (string nivel in niveles)
            {
                if(nivel.Length > 6)
                {
                    listaConsulta.Add(nivel);
                }
 
            }

            var comandoLinq = from nivel in niveles
                              where nivel.Length > 6
                              select nivel;


            List<string> listaResultado = comandoLinq.ToList();
       
            foreach (string nivel in listaResultado)
            {
                //Console.WriteLine(nivel);
            }


            //Sintaxis de metodos
            // 1- Preparacion
            //Func<string, bool> predicado = n => n.Length > 6;
            //var consultaLinqMetodos = niveles.Where(predicado);


            var consultaLinqMetodos = niveles.Where(n => n.Length > 6)
                                             .OrderBy(n => n)
                                             .Select(n => n);




            // 2- Resultados
            List<string> listaMetodoResultado = consultaLinqMetodos.ToList();

            foreach (string nivel in listaMetodoResultado)
            {
                //Console.WriteLine(nivel);
            }

            
        }
    }
}