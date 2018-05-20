using ProyectoXamarin.ViewModels;

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

            BindingContext = new SeccionListPageViewModel();

        }
	}
}