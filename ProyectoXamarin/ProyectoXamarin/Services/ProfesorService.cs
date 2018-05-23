using Newtonsoft.Json;
using Plugin.Connectivity;
using ProyectoXamarin.Models;
using ProyectoXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoXamarin.Services
{
    public class ProfesorService : BaseService
    {
        
        
        public ProfesorService() { }

        public async Task<ObservableCollection<ProfesorItem>> GetProfesoresAsync()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("No Connection");
                return null;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_PROFESOR);
                var response = await client.GetStringAsync("list");
                var profesoresDeserialize = JsonConvert.DeserializeObject<List<Profesor>>(response);

                var profesores = new ObservableCollection<ProfesorItem>();

                foreach (var profesor in profesoresDeserialize)
                {
                    var profesorItem = new ProfesorItem
                    {
                        Icon = profesor.Sexo ? "icon_male" : "icon_female",
                        Profesor = profesor
                    };
                    profesores.Add(profesorItem);
                }

                return profesores;
            }
        }

        public async Task<Profesor> GetProfesorAsync(string id)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("No Connection");
                return null;
            }

            SeccionService service = new SeccionService();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_PROFESOR);
                var response = await client.GetStringAsync(id);
                Profesor profesor = JsonConvert.DeserializeObject<Profesor>(response);
                profesor.Secciones = await service.GetSeccionesByProfesorAsync(profesor.Id);
                return profesor;
            }
        }

    }
}
