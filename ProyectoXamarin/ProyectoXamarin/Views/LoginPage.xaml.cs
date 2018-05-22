using ProyectoXamarin.ViewModels;
using System;

using Xamarin.Forms;

namespace ProyectoXamarin.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

        private async void OnTapNewUserTabbed(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}