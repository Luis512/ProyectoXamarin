using ProyectoXamarin.Views;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProyectoXamarin.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public Command GoToLoginCommand { get; set; }
        public Command GoToProfesorPageCommand { get; set; }
        public Command GoToSeccionPageCommand { get; set; }
        public INavigation Navigation { get; set; }

        public HomePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            GoToProfesorPageCommand = new Command(GoToProfesor);
            GoToSeccionPageCommand = new Command(GoToSeccionPage);
            GoToLoginCommand = new Command(GoToLogin);
        }

        private void GoToLogin()
        {
            var page = new LoginPage();
            page.BindingContext = new LoginPageViewModel();
            Navigation.PushAsync(page);
        }

        private void GoToProfesor()
        {
            var page = new ProfesorListPage();
            page.BindingContext = new ProfesorListPageViewModel();
            Navigation.PushAsync(page);
        }

        private void GoToSeccionPage()
        {
            var page = new SeccionListPage();
            page.BindingContext = new SeccionListPageViewModel();
            Navigation.PushAsync(page);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
