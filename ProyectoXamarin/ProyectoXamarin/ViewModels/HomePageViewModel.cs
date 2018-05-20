using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoXamarin.ViewModels
{
    public class HomePageViewModel
    {
        public ICommand GoToLoginCommand { get; private set; }
        public ICommand GoToProfesorPageCommand { get; private set; }
        public ICommand GoToSeccionPageCommand { get; private set; }
        
        public HomePageViewModel()
        {
            GoToLoginCommand = new Command(GoToLogin());
            GoToProfesorPageCommand = new Command(GoToProfesorPage());
            GoToSeccionPageCommand = new Command(GoToSeccionPage());
        }

        private Action<object> GoToSeccionPage()
        {
            //return new RelayCommand()
        }

        private Action<object> GoToProfesorPage()
        {
            throw new NotImplementedException();
        }

        private Action<object> GoToLogin()
        {
            throw new NotImplementedException();
        }
    }
}
