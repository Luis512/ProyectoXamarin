using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProyectoXamarin.ViewModels
{
    public class SeccionPageViewModel : BaseViewModel
    {
        private SeccionService service { get; set; } 
        private ProfesorService profesorService { get; set; }
        private Seccion _seccion;
        public Seccion Seccion
        {
            get
            {
                return _seccion;
            }
            set
            {
                if (_seccion != value)
                {
                    _seccion = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<ClaseItem> _clases;
        public ObservableCollection<ClaseItem> Clases
        {
            get
            {
                return _clases;
            }
            set
            {
                if (_clases != value)
                {
                    _clases = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _profesor;
        public string Profesor
        {
            get
            {
                return _profesor;
            }
            set
            {
                if (_profesor != value)
                {
                    _profesor = value;
                    OnPropertyChanged();
                }
            }
        }

        public SeccionPageViewModel(Seccion seccion)
        {
            service = new SeccionService();
            GetSeccion(seccion.Id.ToString());
        }

        private async void GetSeccion(string id)
        {
            Seccion = await service.GetSeccionAsync(id);
            ClasesToObservableCollection(Seccion.Clases);
            GetProfesor(Seccion.IdProfesor.ToString());
        }

        private void ClasesToObservableCollection(List<Clase> clases)
        {
            Clases = new ObservableCollection<ClaseItem>();

            foreach (var clase in clases)
            {
                var clasesItem = new ClaseItem
                {
                    Icon = "icon_class",
                    Clase = clase
                };
                Clases.Add(clasesItem);
            }
        }

        private async void GetProfesor(string id)
        {
            profesorService = new ProfesorService();
            var prof = await profesorService.GetProfesorAsync(id);
            Profesor = string.Format("{0} {1}", prof.Nombre, prof.Apellido);
        }
    }

    public class ClaseItem
    {
        public string Icon { get; set; }
        public Clase Clase { get; set; }
    }
}
