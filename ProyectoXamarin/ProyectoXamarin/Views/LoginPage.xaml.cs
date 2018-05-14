using ProyectoXamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

            LoginButton.Clicked += OnTabNewUser;
        }

        private async void OnTabNewUser(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
	}
}