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

            string json = JsonConvert.SerializeObject(monedas);

            File.WriteAllText(jsonPath, json);
            Console.WriteLine(json);

            //Monedas s = JsonConvert.DeserializeObject<Monedas>(json);

            //Console.WriteLine(s.valorEnDolares);

        }
    }
}