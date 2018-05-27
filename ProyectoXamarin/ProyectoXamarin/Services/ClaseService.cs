using Newtonsoft.Json;
using Plugin.Connectivity;
using ProyectoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoXamarin.Services
{
    public class ClaseService : BaseService
    {
        public ClaseService()
        {
        }

        public async Task<Clase> GetClaseAsync(string id)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("No Connection");
                return null;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_CLASE);
                var response = await client.GetStringAsync(id);
                Clase clase = JsonConvert.DeserializeObject<Clase>(response);
                return clase;
            }
        }

        public async Task<bool> RegisterClaseAsync(Clase clase)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("No Connection");
                return false;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_CLASE);
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

                var httpContent = new FormUrlEncodedContent(
               new[]
                {
                   new KeyValuePair<string, string>("idseccion", clase.Id_Seccion.ToString()),
                    new KeyValuePair<string, string>("numero", value:clase.Numero),
                    new KeyValuePair<string, string>("notas", value:clase.Notas),
                });

                var response = await client.PostAsync("new", httpContent);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    return false;
                return true;
            }
        }

        public async Task<List<Clase>> GetClasesBySeccion(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_CLASE);
                var response = await client.GetStringAsync("seccion/" + id);
                return JsonConvert.DeserializeObject<List<Clase>>(response);
            }
        }

        public async Task<bool> DeleteClaseAsync(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_CLASE);
        
                var response = await client.DeleteAsync(id);

                if (!response.IsSuccessStatusCode)
                    return false;
                return true;
            }
        }
    }
}
