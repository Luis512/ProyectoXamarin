using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace ProyectoXamarin.ViewModels
{
    public class ClasePageViewModel : BaseViewModel
    {
        public ClaseService service { get; set; }
        public Command DeleteCommand { get; set; }
        public INavigation Navigation { get; set; }
        public string Id { get; set; } = string.Empty;

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

        public ClasePageViewModel(string id, INavigation navigation)
        {
            Navigation = navigation;
            service = new ClaseService();
            DeleteCommand = new Command(DeleteClase);
            Id = id;
            GetClase();
        }

        private async void GetClase()
        {
            Clase = await service.GetClaseAsync(Id);           
        }

        private async void DeleteClase()
        {
            var wasSuccessful = await service.DeleteClaseAsync(Id);

            if (!wasSuccessful) { 
                Debug.WriteLine("Se elimino correctamente");
                await Navigation.PopAsync();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Hubo un error al eliminar la clase.", "Cancel");
            }           
        }

    }
}
