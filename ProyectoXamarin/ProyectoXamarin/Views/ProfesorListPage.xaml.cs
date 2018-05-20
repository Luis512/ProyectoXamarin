using ProyectoXamarin.ViewModels;
using System.Collections.ObjectModel;
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

            BindingContext = new ProfesorListPageViewModel();
        }

        void OnSeccionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var profesor = ((ListView)sender).SelectedItem as ProfesorItem;
            if (profesor == null)
                return;
            DisplayAlert("Seleccionado:", $"{profesor.Profesor.Nombre}", "Cerrar");
        }
    }
}