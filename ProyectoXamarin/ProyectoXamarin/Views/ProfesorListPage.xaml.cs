using ProyectoXamarin.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfesorListPage : ContentPage
	{
        public ObservableCollection<ProfesorItem> Profesores { get; set; }

        public ProfesorListPage ()
		{
            Profesores = new ObservableCollection<ProfesorItem>();

            InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            IsBusy = true;
            try
            {
                BindingContext = new ProfesorListPageViewModel();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void OnSeccionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var profesor = ((ListView)sender).SelectedItem as ProfesorItem;
            if (profesor == null)
                return;
            var page = new ProfesorPage();
            page.BindingContext = new ProfesorPageViewModel(profesor.Profesor);
            Navigation.PushAsync(page);
        }
    }
}