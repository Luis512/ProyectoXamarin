using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using ProyectoXamarin.Views;
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
        public Command GoToUpdateCommand { get; set; }
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
            GoToUpdateCommand = new Command(GotoUpdate);
            Id = id;
            GetClase();
        }

        private void GotoUpdate()
        {
            var page = new ClaseEdit();
            page.BindingContext = new ClaseEditPageViewModel(Clase, Navigation);
            Navigation.PushAsync(page);
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
