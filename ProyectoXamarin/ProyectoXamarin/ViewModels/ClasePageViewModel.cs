using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoXamarin.ViewModels
{
    public class ClasePageViewModel : BaseViewModel
    {
        public ClaseService service { get; set; }
        private Clase _clase;
        public Clase Clase
        {
            get
            {
                return _clase;
            }
            set
            {
                if (_clase != value)
                {
                    _clase = value;
                    OnPropertyChanged();
                }
            }
        }

        public ClasePageViewModel(string id)
        {
            service = new ClaseService();
            GetClase(id);
        }

        private async void GetClase(string id)
        {
            Clase = await service.GetClaseAsync(id);
        }

    }
}
