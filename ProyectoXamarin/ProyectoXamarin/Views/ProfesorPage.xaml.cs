using ProyectoXamarin.Models;
using ProyectoXamarin.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfesorPage : ContentPage
	{
        public ObservableCollection<SeccionItem> Secciones { get; set; } = new ObservableCollection<SeccionItem>();
        public Profesor Profesor { get; set; }

        public ProfesorPage()
        {
            Secciones = new ObservableCollection<SeccionItem>();
            Profesor = new Profesor();

            InitializeComponent();

            BindingContext = new ProfesorPageViewModel();
        }

        void OnSeccionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var seccion = ((ListView)sender).SelectedItem as SeccionItem;
            if (seccion == null)
                return;
            DisplayAlert("Seleccionado:", $"{seccion.Seccion.Numero}", "Cerrar");
        }
    }

}
