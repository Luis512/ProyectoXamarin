using Newtonsoft.Json;
using ProyectoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoXamarin.Services
{
    public class ProfesorService
    {
        public const string SERVICE_ENDPOINT = "http://localhost:8080/profesor";

        public async Task<List<Profesor>> GetProfesoresAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT);

                var response = await client.GetStringAsync("list");

                return JsonConvert.DeserializeObject<List<Profesor>>(response);
            }
        }
    }
}
