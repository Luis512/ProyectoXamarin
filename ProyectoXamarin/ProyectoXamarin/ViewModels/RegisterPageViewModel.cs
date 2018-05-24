using ProyectoXamarin.Models;
using ProyectoXamarin.Services;
using ProyectoXamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoXamarin.ViewModels
{
    public class RegisterPageViewModel : BaseViewModel
    {
        private ProfesorService service { get; set; }
        public string SexoSeleccionado { get; set; }
        private INavigation Navigation { get; set; }
        private Profesor _profesor;

        public List<string> Sexo { get; set; } = new List<string>
        {
            { "Masculino"},
            { "Femenino"}
        };

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
        public Command RegisterCommand { get; set; }

        public RegisterPageViewModel(INavigation navigation)
        {
            service = new ProfesorService();
            Profesor = new Profesor();
            Navigation = navigation;

            RegisterCommand = new Command(Register);
        }

        private async void Register()
        {
            if (SexoSeleccionado.Equals("Masculino"))
                Profesor.Sexo = true;
            var result = await service.RegisterProfesorAsync(Profesor);
            if (result)
            {
                var page = new HomePage();
                page.BindingContext = new HomePageViewModel(Navigation);
                await Navigation.PushAsync(page);
            }
        }


    }
}
