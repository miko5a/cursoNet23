using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{
    public class CRUDService : IIntegrationService
    {
        private static HttpClient _httpClient = new HttpClient();
        private static HttpClient _httpClientActividad = new HttpClient();
        public CRUDService()
        {
            _httpClient.BaseAddress = new Uri("http://localhost:57863");
            _httpClientActividad.BaseAddress = new Uri("https://www.boredapi.com/");
        }
        public async Task Run()
        {
            //await EjemploGet();
            await EjemploGetActividad();
        }

        private async Task EjemploGet()
        {
            var respuesta = await _httpClient.GetAsync("api/movies");

            respuesta.EnsureSuccessStatusCode();

            var content = await respuesta.Content.ReadAsStringAsync();

            var movies = new List<Movie>();
            movies = JsonConvert.DeserializeObject<List<Movie>>(content);
        }

        private async Task EjemploGetActividad()
        {
            var respuesta = await _httpClientActividad.GetAsync("api/activity");

            respuesta.EnsureSuccessStatusCode();

            var content = await respuesta.Content.ReadAsStringAsync();

            Actividades actividad = JsonConvert.DeserializeObject<Actividades>(content);

            Console.WriteLine($"Actividad: {actividad.activity}");
        }
    }
}
