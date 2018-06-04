using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoXamarin.ViewModels
{
    class ClaseEditPageViewModel : BaseViewModel
    {
        public ClaseService service { get; set; }
        public Command UpdateCommand { get; set; }
        public INavigation Navigation { get; set; }

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

        public ClaseEditPageViewModel(Clase clase,INavigation navigation)
        {
            Navigation = navigation;
            Clase = clase;
            UpdateCommand = new Command(UpdateClase);
        }

        private async void UpdateClase()
        {
            service = new ClaseService();
            var result = await service.UpdateClaseAsync(Clase);
            if (result)
            {
                await Navigation.PopAsync();
            }
        }
    }
}
