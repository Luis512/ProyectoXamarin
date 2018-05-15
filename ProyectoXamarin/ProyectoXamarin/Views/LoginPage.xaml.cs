using System;

using Xamarin.Forms;

namespace ProyectoXamarin.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnTapNewUserTabbed(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}