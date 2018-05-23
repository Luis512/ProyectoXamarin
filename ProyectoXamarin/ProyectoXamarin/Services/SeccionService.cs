﻿using Newtonsoft.Json;
using ProyectoXamarin.Models;
using ProyectoXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoXamarin.Services
{
    public class SeccionService : BaseService
    {

        public async Task<ObservableCollection<SeccionItem>> GetSeccionesAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_SECCION);
                var response = await client.GetStringAsync("list");
                var seccionesDeserialize = JsonConvert.DeserializeObject<List<Seccion>>(response);

                var secciones = new ObservableCollection<SeccionItem>();

                foreach (var seccion in seccionesDeserialize)
                {
                    var seccionItem = new SeccionItem
                    {
                        Icon = "icon_classroom",
                        Seccion = seccion
                    };
                    secciones.Add(seccionItem);
                }

                return secciones;
            }
        }

        public async Task<List<Seccion>> GetSeccionesByProfesorAsync(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT_SECCION);
                var response = await client.GetStringAsync("profesor/"+id);
               return JsonConvert.DeserializeObject<List<Seccion>>(response);
            }
        }
    }
}
