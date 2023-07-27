using DataProcessor;
using Newtonsoft.Json;

namespace ImportarJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string json = @"{
            //  'Name': 'Bad Boys',
            //  'ReleaseDate': '1995-4-7T00:00:00',
            //  'Genres': [
            //    'Action',
            //    'Comedy'
            //  ]
            //}";

            //Movie m = JsonConvert.DeserializeObject<Movie>(json);

            //string name = m.Genres[1];

            //Console.WriteLine(name);

            string jsonPath = @"c:\archivos\monedas.json";

            Monedas moneda1 = new Monedas("Dólar estadounidense","USD",1.0);
            Monedas moneda2 = new Monedas("Euro","EUR",1.18);
            Monedas moneda3 = new Monedas("Yen japonés","JPY",0.0090);
            Monedas moneda4 = new Monedas("Libra","GBP",1.39);

            var monedas = new List<Monedas>();
            monedas.Add(moneda1);
            monedas.Add(moneda2);
            monedas.Add(moneda3);
            monedas.Add(moneda4);

            // Serializo la lista de monedas en un json
            string json = JsonConvert.SerializeObject(monedas);

            //Escribo en el archivo
            //TODO: Comprobar si el directorio existe
            File.WriteAllText(jsonPath, json);
           
            
            //Leer Archivo
            string readText = File.ReadAllText(jsonPath);
            // Deserializa el json en la lista de monedas
            List<Monedas> listaMonedas = JsonConvert.DeserializeObject<List<Monedas>>(readText);

            foreach (Monedas moneda in listaMonedas)
            {
                string name = moneda.nombre;
                string code = moneda.codigo;
                double value = moneda.valorEnDolares;

                if (name == "Euro")
                {
                    code = "EURR";
                }

                Console.WriteLine($" Moneda: {name} | Codigo: {code} | Valor en USD: {value}.");

            }

        }
    }
}