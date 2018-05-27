using ProyectoXamarin.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeccionListPage : ContentPage
	{
		public SeccionListPage ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            IsBusy = true;
            try
            {
                BindingContext = new SeccionListPageViewModel();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void OnSeccionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var seccion = ((ListView)sender).SelectedItem as SeccionItem;
            if (seccion == null)
                return;
            var page = new SeccionPage();
            page.BindingContext = new SeccionPageViewModel(seccion.Seccion);
            Navigation.PushAsync(page);
        }
    }
}