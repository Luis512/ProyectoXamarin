using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProyectoXamarin.ViewModels
{
    public class SeccionItem
    {
        public string Icon { get; set; }
        public Seccion Seccion { get; set; }
    }

    public class ProfesorPageViewModel : BaseViewModel
    {
        private ProfesorService service;

        private ObservableCollection<SeccionItem> _secciones;
        public ObservableCollection<SeccionItem> Secciones
        {
            get
            {
                return _secciones;
            }
            set
            {
                if (_secciones != value)
                {
                    _secciones = value;
                    OnPropertyChanged();
                }
            }
        }

        private Profesor _profesor;
        public Profesor Profesor
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
        
        public ProfesorPageViewModel(Profesor profesor)
        {
            service = new ProfesorService();
            GetProfesor(profesor.Id);
        }   
        
        private async void GetProfesor(string id)
        {
            Profesor = await service.GetProfesorAsync(id);
            SeccionesToObservableCollection(Profesor.Secciones);
        }

        private void SeccionesToObservableCollection(List<Seccion> secciones)
        {
            Secciones = new ObservableCollection<SeccionItem>();

            foreach(var seccion in secciones)
            {
                var seccionItem = new SeccionItem
                {
                    Icon = "icon_classroom",
                    Seccion = seccion
                };
                Secciones.Add(seccionItem);
            }
        }
    }
}
