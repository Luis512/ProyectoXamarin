using ProyectoXamarin.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeccionPage : ContentPage
    {
		public SeccionPage ()
		{
			InitializeComponent ();
		}

        void OnClaseSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var clase = ((ListView)sender).SelectedItem as ClaseItem;
            if (clase == null)
                return;
            var page = new ClasePage();
            page.BindingContext = new ClasePageViewModel(clase.Clase.Id.ToString());
            Navigation.PushAsync(page);
        }
    }
}